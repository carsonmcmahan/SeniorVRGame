using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleLivingroom : MonoBehaviour
{
    [SerializeField] private GameObject livingroom;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Livingroom_Porch")
        {
            livingroom.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Livingroom_Porch")
        {
            livingroom.SetActive(false);
        }
    }
}
