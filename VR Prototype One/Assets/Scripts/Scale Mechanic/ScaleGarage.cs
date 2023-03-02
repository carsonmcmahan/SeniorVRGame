using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleGarage : MonoBehaviour
{
    [SerializeField] private GameObject garage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Garage")
        {
            garage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Garage")
        {
            garage.SetActive(false);
        }
    }
}
