using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBedroom : MonoBehaviour
{
    [SerializeField] private GameObject bedroom;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Bedrooms")
        {
            bedroom.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Bedrooms")
        {
            bedroom.SetActive(false);
        }
    }
}
