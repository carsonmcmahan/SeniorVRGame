using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSystem : MonoBehaviour
{
    [Header("Objects to Place")]
    public GameObject[] objects;
    private GameObject pendingObject;

    // Layer Masks 
    [SerializeField] private LayerMask layerMaskOne;
    [SerializeField] private LayerMask layerMaskTwo;

    // Vector3 position and raycast 
    private Vector3 position;
    private RaycastHit hit;

    // Rotate amount, size of grid, adn boolean to tell if the grid is working
    private float rotateAmount = 45f;
    private float gridSize = 1f;
    private bool gridOn = true;

    private void Update()
    {
        // Select object to place method
        SelectObjectInput();

        if (pendingObject != null)
        {
            if (gridOn)
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

            if (Input.GetMouseButtonDown(0))
            {
                PlaceObject();
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                RotateObject();
            }
        }
    }

    private void FixedUpdate()
    {
        // Raycast from the camera
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Checking to see if the ray hits the first layermask
        if (Physics.Raycast(ray, out hit, 100, layerMaskOne))
        {
            position = hit.point;
        }

        // Checking to see if the ray hits the second layermask
        if (Physics.Raycast(ray, out hit, 100, layerMaskTwo))
        {
            position = hit.point;
        }
    }

    //Places the object
    public void PlaceObject()
    {
        pendingObject = null;
    }

    //Selects an object
    public void SelectObjects(int index)
    {
        pendingObject = Instantiate(objects[index], position, transform.rotation);
    }

    //Inputs to select a certain object
    public void SelectObjectInput()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            SelectObjects(0);
            Debug.Log("pressed");
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            SelectObjects(1);
            Debug.Log("pressed");
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            SelectObjects(2);
            Debug.Log("pressed");
        }
    }

    // Rotates the selected object
    public void RotateObject()
    {
        pendingObject.transform.Rotate(Vector3.up, rotateAmount);
    }

    // 
    public void ToggleGrid()
    {
        gridOn = true;
    }

    // Determines how big the grid is 
    // gridSize is how big the grid will actually be
    // tested between 0.5 and 1
    // these seem like the best options
    float RoundToNearestGrid(float pos)
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