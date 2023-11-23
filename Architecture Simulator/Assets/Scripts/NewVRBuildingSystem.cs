using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class NewVRBuildingSystem : MonoBehaviour
{
    public Transform rightController;
    public float placeDistance = 100;
    public LayerMask buildAreaLayerMask;
    [Space]
    public GameObject[] buildingPrefabs;

    int arrayCount = 0;

    GameObject previewPrefab;

    Vector3 position;
    RaycastHit hit;

    private void Update()
    {
        if(previewPrefab != null)
        {
            previewPrefab.transform.position = position;

            if (Input.GetButtonDown("XRI_Right_TriggerButton"))
            {
                // instantiate preview object 
                previewPrefab = Instantiate(buildingPrefabs[0], position, Quaternion.identity);
            }

            if (Input.GetButtonUp("XRI_Right_TriggerButton"))
            {
                // instantiate real object
                previewPrefab = null;
            }
        }

        if(Input.GetButton("XRI_Right_PrimaryButton"))
        {
            SelectObject();
        }
    }

    private void FixedUpdate()
    {
        // raycast from the right controller
        Ray rightControllerRay = new(rightController.position, rightController.forward);

        if(Physics.Raycast(rightControllerRay, out hit, placeDistance, buildAreaLayerMask)) 
        {
            // setting a Vector3 to the point the raycast hits
            position = hit.point;
        }
    }

    private void SelectObject()
    {
        arrayCount++;

        if(arrayCount > buildingPrefabs.Length - 1)
        {
            arrayCount = 0;
        }
    }
}
