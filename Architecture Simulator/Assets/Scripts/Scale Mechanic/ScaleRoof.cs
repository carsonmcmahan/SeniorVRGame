using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleRoof : MonoBehaviour
{
    [SerializeField] private GameObject roof;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Roof")
        {
            roof.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Roof")
        {
            roof.SetActive(false);
        }
    }
}
