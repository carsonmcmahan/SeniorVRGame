using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    [SerializeField] private GameObject[] housePrfabs;

    private void Start()
    {
        for(int i = 0; i < housePrfabs.Length; i++)
        {
            housePrfabs[i].SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("HouseOne"))
        {
            housePrfabs[0].SetActive(true);
        }

        if (other.gameObject.CompareTag("HouseTwo"))
        {
            housePrfabs[1].SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("HouseOne"))
        {
            housePrfabs[0].SetActive(false);
        }

        if (other.gameObject.CompareTag("HouseTwo"))
        {
            housePrfabs[1].SetActive(false);
        }
    }
}
