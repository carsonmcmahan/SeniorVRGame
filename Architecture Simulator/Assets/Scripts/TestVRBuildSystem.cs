using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class TestVRBuildSystem : MonoBehaviour
{
    public Transform rightController;
    public GameObject[] objects;
    GameObject pendingObject;

    [SerializeField] private LayerMask buildArea;

    Vector3 position;
    RaycastHit hit;

    // Rotate amount, size of grid, adn boolean to tell if the grid is working
    private float gridSize = 1f;
    private bool gridOn = true;

    // Update is called once per frame
    private void Update()
    {
        if(pendingObject != null)
        {
            if(gridOn)
            {
                // rounds object to the nearest int
                pendingObject.transform.position = new Vector3(
                    RoundToNearestGrid(position.x),
                    RoundToNearestGrid(position.y),
                    RoundToNearestGrid(position.z));
            }
            else
            {
                pendingObject.transform.position = position;
            }

            if (Input.GetButtonDown("XRI_Right_TriggerButton"))
            {
                PlaceObject();
                Debug.Log(hit.transform);
            }
        }
    }

    private void FixedUpdate()
    {
        Ray ray = new(rightController.position, rightController.forward);

        if (Physics.Raycast(ray, out hit, buildArea))
        {
            position = hit.point;
        }
    }

    private void PlaceObject()
    {
        pendingObject = null;
    }

    // Rotates the selected object

    //Selects an object
    public void SelectObjects(int index)
    {
        pendingObject = Instantiate(objects[index], position, transform.rotation);
    }

    private void ToggleGrid()
    {
        gridOn = true;
    }

    // Determines how big the grid is 
    // gridSize is how big the grid will actually be
    // tested between 0.5 and 1
    // these seem like the best options
    private float RoundToNearestGrid(float pos)
    {
        float xDiff = pos % gridSize;
        pos -= xDiff;

        if (xDiff > (gridSize / 2))
        {
            pos += gridSize;
        }

        return pos;
    }
}
