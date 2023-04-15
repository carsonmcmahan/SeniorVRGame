using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{ 
    [Header("Objects To Spawn")]
    [SerializeField] private GameObject bedrooms;
    [SerializeField] private GameObject kitchen;
    [SerializeField] private GameObject livingroom;
    [SerializeField] private GameObject garage;
    [SerializeField] private GameObject roof;

    [Header("Audio")] //adds audio to a UI button when its pressed
    public AudioSource livingroomButton;
    public AudioSource garageButton;
    public AudioSource kitchenButton;
    public AudioSource bedroomsButton;
    public AudioSource roofButton;

    public void SpawnBedrooms()
    {
        bedrooms.SetActive(true);
        bedroomsButton.Play();
    }

    public void SpawnKitchen()
    {
        kitchen.SetActive(true);
        kitchenButton.Play();
    }

    public void SpawnLivingroom()
    {
        livingroom.SetActive(true);
        livingroomButton.Play();
    }

    public void SpawnGarage()
    {
        garage.SetActive(true);
        garageButton.Play();
    }

    public void SpawnRoof()
    {
        roof.SetActive(true);
        roofButton.Play();
    }
}
