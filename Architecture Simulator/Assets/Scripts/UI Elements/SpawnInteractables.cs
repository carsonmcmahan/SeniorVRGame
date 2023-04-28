using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnInteractables : MonoBehaviour
{
    [Header("Spawn Location")]
    [SerializeField] private Transform spawnLocation;

    [Header("House One")]
    public GameObject cloneBedroomOne;
    public GameObject cloneBedroomTwo;
    public GameObject cloneGarageOne;
    public GameObject cloneMasterOne;
    public GameObject cloneBathroomOne;
    public GameObject cloneKitchenOne;
    public GameObject cloneRoofOne;

    [Header("House One Bools")]
    public bool bedroomOnePressed = false;
    public bool bedroomTwoPressed = false;
    public bool garageOnePressed = false;
    public bool masterOnePressed = false;
    public bool bathroomOnePressed = false;
    public bool kitchenOnePressed = false;
    public bool roofOnePressed= false;

    [Header("House Two")]
    public GameObject cloneLivingroomTwo;
    public GameObject cloneGarageTwo;
    public GameObject cloneKitchenTwo;
    public GameObject cloneBedroomsTwo;
    public GameObject cloneRoofTwo;

    [Header("House Two Bools")]
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

        cloneBedroomOne = GameObject.Find("Bedroom One(Clone)");
        cloneBedroomTwo = GameObject.Find("Bedroom Two(Clone)");
        cloneGarageOne = GameObject.Find("Garage(Clone)");
        cloneMasterOne = GameObject.Find("Master(Clone)");
        cloneKitchenOne = GameObject.Find("Kitchen(Clone)");
        cloneRoofOne = GameObject.Find("Roof(Clone)");
    }

    public void SpawnBedroomOne(GameObject prefab)
    {
        if(bedroomOnePressed == false)
        {
            cloneBedroomOne = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            bedroomOnePressed = true;
        }
        else
        {
            Debug.Log("Object already in scene! " + bedroomOnePressed);
        }
    }

    public void SpawnBedromTwo(GameObject prefab)
    {
        if(bedroomTwoPressed == false)
        {
            cloneBedroomsTwo = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            bedroomTwoPressed = true;
        }
        else
        {
            Debug.Log("Object already in scene! " + bedroomTwoPressed);
        }
    }

    public void SpawnGarageOne(GameObject prefab)
    {
        if(garageOnePressed == false)
        {
            cloneGarageOne = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            garageOnePressed = true;
        }
        else
        {
            Debug.Log("Object already in scene! " + garageOnePressed);
        }
    }

    public void SpawnMasterOne(GameObject prefab)
    {
        if(masterOnePressed == false)
        {
            cloneMasterOne = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            masterOnePressed = true;
        }
        else
        {
            Debug.Log("Object already in scene! " + masterOnePressed);
        }
    }

    public void SpawnBathroomOne(GameObject prefab)
    {
        if(bathroomOnePressed == false)
        {
            cloneBathroomOne = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            bathroomOnePressed = true;
        }
        else
        {
            Debug.Log("Object already in scene! " + bathroomOnePressed);
        }
    }

    public void SpawnKitchenOne(GameObject prefab)
    {
        if(kitchenOnePressed == false)
        {
            cloneKitchenOne = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            kitchenOnePressed = true;
        }
        else
        {
            Debug.Log("Object already in scene! " + kitchenOnePressed);
        }
    }

    public void SpawnRoofOne(GameObject prefab)
    {
        if(roofOnePressed == false)
        {
            cloneGarageOne = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            roofOnePressed = true;
        }
        else
        {
            Debug.Log("Object already in scene! " + roofOnePressed);
        }
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