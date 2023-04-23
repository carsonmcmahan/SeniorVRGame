using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleGarage : MonoBehaviour
{
    [SerializeField] private GameObject garageTwo;
    [SerializeField] private Transform spawnPoint;
    private GameObject clonePrefab;

    private void Start()
    {
        clonePrefab = GameObject.Find("Garage_Two_Normal(Clone)");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Garage_Two_Interactable")
        {
            clonePrefab = Instantiate(garageTwo, spawnPoint.position, spawnPoint.rotation);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Garage_Two_Interactable")
        {
            Destroy(clonePrefab);
        }
    }
}
