using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewVRBuildingSystem : MonoBehaviour
{
    public Transform rightController;
    public float placeDistance = 100;
    public LayerMask buildAreaLayerMask;


    Vector3 position;
    RaycastHit hit;

    private void Update()
    {
        if(Input.GetButton("XRI_Right_TriggerButton"))
        {
            Debug.Log(position);
        }

        if(Input.GetButton("XRI_Right_PrimaryButton"))
        {
            Debug.Log("Pressed");
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
}
