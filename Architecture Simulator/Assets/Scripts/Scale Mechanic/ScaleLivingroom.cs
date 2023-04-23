using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleLivingroom : MonoBehaviour
{
    [SerializeField] private GameObject livingroomTwo;
    [SerializeField] private Transform spawnPoint;
    private GameObject clonePrefab;

    private void Start()
    {
        clonePrefab = GameObject.Find("Livingroom_Master_Two_Normal(Clone)");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Livingroom_Master_Two_Interactable")
        {
            clonePrefab = Instantiate(livingroomTwo, spawnPoint.position, spawnPoint.rotation);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Livingroom_Master_Two_Interactable")
        {
            Destroy(clonePrefab);
        }
    }
}
