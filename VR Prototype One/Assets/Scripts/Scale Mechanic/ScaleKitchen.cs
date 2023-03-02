using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleKitchen : MonoBehaviour
{
    [SerializeField] private GameObject kitchen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Kitchen")
        {
            kitchen.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Kitchen")
        {
            kitchen.SetActive(false);
        }
    }

    //This is how i wanted it to work. However the destroy function does not work for some reason
    //gives an error that says "cant destroy game data."

    //[SerializeField] private GameObject kitchen;
    //[SerializeField] private Vector3 spawn;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "Kitchen")
    //    {
    //        Instantiate(kitchen, spawn, Quaternion.identity);
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.name == "Kitchen")
    //    {
    //        Destroy(kitchen);
    //    }
    //}
}
