using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBedroom : MonoBehaviour
{
    [SerializeField] private GameObject bedroomTwo;
    [SerializeField] private Transform spawnPoint;
    private GameObject clonePrefab;

    private void Start()
    {
        clonePrefab = GameObject.Find("Bedrooms_Two_Normal(Clone)");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bedrooms_Two_Interactable")
        {
            clonePrefab = Instantiate(bedroomTwo, spawnPoint.position, spawnPoint.rotation);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Bedrooms_Two_Interactable")
        {
            Destroy(clonePrefab);
        }
    }
}
