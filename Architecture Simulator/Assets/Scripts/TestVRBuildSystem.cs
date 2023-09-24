using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVRBuildSystem : MonoBehaviour
{
    [SerializeField] private Transform rightController;
    [SerializeField] private Transform leftController;
    [SerializeField] private float gridSize = 1f;
    [SerializeField] private LayerMask[] layerMasks;
    [Space]
    [SerializeField] private GameObject[] objects;

    GameObject pendingObject;
    Vector3 position;
    RaycastHit hit;

    Building building;

    // Rotate amount, size of grid, adn boolean to tell if the grid is working
    private bool gridOn = true;

    // Update is called once per frame
    private void Update()
    {
        Ray left = new(leftController.position, leftController.forward);

        if (Physics.Raycast(left, out hit, 100, layerMasks[1]))
        {
            if (Input.GetButtonDown("XRI_Left_TriggerButton"))
            {
                if(hit.transform.TryGetComponent(out building))
                {
                    building.DestroyBuilding();
                }
            }
        }

        if (pendingObject != null)
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
        // adding a ray to the right controller
        Ray right = new(rightController.position, rightController.forward);

        

        // shooting the ray
        if (Physics.Raycast(right, out hit, 100, layerMasks[0]))
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
