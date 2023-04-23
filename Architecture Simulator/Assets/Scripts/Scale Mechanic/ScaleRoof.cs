using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleRoof : MonoBehaviour
{
    [SerializeField] private GameObject roofTwo;
    [SerializeField] private Transform spawnPoint;
    private GameObject clonePrefab;

    private void Start()
    {
        clonePrefab = GameObject.Find("Roof_Two_Normal(Clone)");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Roof_Two_Interactable")
        {
            clonePrefab = Instantiate(roofTwo, spawnPoint.position, spawnPoint.rotation);

            Debug.Log("spawned");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Roof_Two_Interactable")
        {
            Destroy(clonePrefab);

            Debug.Log("Destroyed");
        }
    }
}
