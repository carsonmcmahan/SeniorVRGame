using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleKitchen : MonoBehaviour
{
    [SerializeField] private GameObject kitchenTwo;
    [SerializeField] private Transform spawnPoint;
    private GameObject clonePrefab;

    private void Start()
    {
        clonePrefab = GameObject.Find("Kitchen_Master_Two_Normal(Clone)");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Kitchen_Master_Two_Interactable")
        {
            clonePrefab = Instantiate(kitchenTwo, spawnPoint.position, spawnPoint.rotation);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Kitchen_Master_Two_Interactable")
        {
            Destroy(clonePrefab);
        }
    }
}
