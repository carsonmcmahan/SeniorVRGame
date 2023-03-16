using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSystem : MonoBehaviour
{
    // Objects
    public GameObject[] objects;
    private GameObject pendingObject;

    // Layer Masks 
    [SerializeField] private LayerMask layerMaskOne;
    [SerializeField] private LayerMask layerMaskTwo;

    // Vector3 position and raycast 
    private Vector3 position;
    private RaycastHit hit;

    // Rotate amount, size of grid, adn boolean to tell if the grid is working
    private float rotateAmount = 45;
    private float gridSize = 1f;
    private bool gridOn = true;

    private void Update()
    {
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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100, layerMaskOne))
        {
            position = hit.point;
        }

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

    //Rotates the selected object
    public void RotateObject()
    {
        pendingObject.transform.Rotate(Vector3.up, rotateAmount);
    }

    //These two methods make up the grid.
    //Grid is always on and the second method determines how big the grid is
    public void ToggleGrid()
    {
        gridOn = true;
    }

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
