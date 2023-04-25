using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInteractable : MonoBehaviour
{
    [Header("Script Reference")]
    public SpawnInteractables spawnInteracs;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bedrooms_Two_Interactable")
        {
            Destroy(spawnInteracs.cloneBedroomsTwo);
            spawnInteracs.bedroomsPressed = false;
            
            Debug.Log("Object Destroyed!");
        }

        if(other.gameObject.tag == "Garage_Two_Interactable")
        {
            Destroy(spawnInteracs.cloneGarageTwo);
            spawnInteracs.garagePressed = false;

            Debug.Log("Object Destroyed!");
        }

        if(other.gameObject.tag == "Kitchen_Master_Two_Interactable")
        {
            Destroy(spawnInteracs.cloneKitchenTwo);
            spawnInteracs.kitchenPressed = false;

            Debug.Log("Object Destroyed!");
        }

        if(other.gameObject.tag == "Livingroom_Master_Two_Interactable")
        {
            Destroy(spawnInteracs.cloneLivingroomTwo);
            spawnInteracs.livingroomPressed = false;
            Debug.Log("Object Destroyed!");
        }

        if(other.gameObject.tag == "Roof_Two_Interactable")
        {
            Destroy(spawnInteracs.cloneRoofTwo);
            spawnInteracs.roofPressed = false;

            Debug.Log("Object Destroyed!");
        }
    }
}
