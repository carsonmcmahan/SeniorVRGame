using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInteractable : MonoBehaviour
{
    [Header("Script Reference")]
    public ButtonManager buttonManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bedrooms_Two_Interactable")
        {
            Destroy(buttonManager.cloneBedroomsTwo);
            buttonManager.bedroomsPressed = false;

            Debug.Log("Object Destroyed!");
        }

        if(other.gameObject.tag == "Garage_Two_Interactable")
        {
            Destroy(buttonManager.cloneGarageTwo);
            buttonManager.garagePressed = false;

            Debug.Log("Object Destroyed!");
        }

        if(other.gameObject.tag == "Kitchen_Master_Two_Interactable")
        {
            Destroy(buttonManager.cloneKitchenTwo);
            buttonManager.kitchenPressed = false;

            Debug.Log("Object Destroyed!");
        }

        if(other.gameObject.tag == "Livingroom_Master_Two_Interactable")
        {
            Destroy(buttonManager.cloneLivingroomTwo);
            buttonManager.livingroomPressed = false;

            Debug.Log("Object Destroyed!");
        }

        if(other.gameObject.tag == "Roof_Two_Interactable")
        {
            Destroy(buttonManager.cloneRoofTwo);
            buttonManager.roofPressed = false;

            Debug.Log("Object Destroyed!");
        }
    }
}
