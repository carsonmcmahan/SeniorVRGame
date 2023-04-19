using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScaleScript : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject clonePrefab;
    [SerializeField] private Transform spawnPoint;

    private void Start()
    {
        clonePrefab = GameObject.Find("Bedrooms_Two_Normal(Clone)");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bedrooms_Two_Interactable")
        {
            clonePrefab = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Bedrooms_Two_Interactable")
        {
            Destroy(clonePrefab);
        }
    }
}
