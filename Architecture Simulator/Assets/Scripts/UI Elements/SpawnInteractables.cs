using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnInteractables : MonoBehaviour
{
    [Header("Spawn Location")]
    [SerializeField] private Transform spawnLocation;

    [Header("Objects to Spawn")]
    public GameObject cloneLivingroomTwo;
    public GameObject cloneGarageTwo;
    public GameObject cloneKitchenTwo;
    public GameObject cloneBedroomsTwo;
    public GameObject cloneRoofTwo;

    [Header("Bools to check if object is in the scene")]
    public bool livingroomPressed = false;
    public bool garagePressed = false;
    public bool kitchenPressed = false;
    public bool bedroomsPressed = false;
    public bool roofPressed = false;

    [Header("Audio")] //adds audio to a UI button when its pressed
    public AudioSource livingroomButton;
    public AudioSource garageButton;
    public AudioSource kitchenButton;
    public AudioSource bedroomsButton;
    public AudioSource roofButton;

    public void Start()
    {
        cloneBedroomsTwo = GameObject.Find("bedrooms_two(clone)");
        cloneGarageTwo = GameObject.Find("Garage_Two(Clone)");
        cloneLivingroomTwo = GameObject.Find("Livingroom_Two(Clone)");
        cloneKitchenTwo = GameObject.Find("Kitchen_Two(Clone)");
        cloneRoofTwo = GameObject.Find("Roof_Two(Clone)");
    }

    public void SpawnLivingroom(GameObject prefab)
    {
        if (livingroomPressed == false)
        {
            cloneLivingroomTwo = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            livingroomPressed = true;
            livingroomButton.Play();
        }
        else
        {
            livingroomButton.Play();
            Debug.Log("Object already in scene! " + livingroomPressed);
        }
    }

    public void SpawnGarage(GameObject prefab)
    {
        if (garagePressed == false)
        {
            cloneGarageTwo = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            garagePressed = true;
            garageButton.Play();
        }
        else
        {
            garageButton.Play();

            Debug.Log("Object already in scene! " + garagePressed);
        }
    }

    public void SpawnKitchen(GameObject prefab)
    {

        if (kitchenPressed == false)
        {
            cloneKitchenTwo = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            kitchenPressed = true;
            kitchenButton.Play();
        }
        else
        {
            kitchenButton.Play();

            Debug.Log("Object already in scene! " + kitchenPressed);
        }
    }

    public void SpawnBedrooms(GameObject prefab)
    {
        if (bedroomsPressed == false)
        {
            cloneBedroomsTwo = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            bedroomsPressed = true;
            bedroomsButton.Play();
        }
        else
        {
            bedroomsButton.Play();

            Debug.Log("Object already in scene! " + bedroomsPressed);
        }
    }

    public void SpawnRoof(GameObject prefab)
    {
        if (roofPressed == false)
        {
            cloneRoofTwo = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            roofPressed = true;
            roofButton.Play();
        }
        else
        {
            roofButton.Play();

            Debug.Log("Object already in scene! " + roofPressed);
        }
    }
}
