using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletCheck : MonoBehaviour
{
    [Tooltip("This Bool checks to see if the tablet is in the Trigger. If it is equal to false then the tablet will teleport back to the socket.")]
    [Header("Bool")]
    [SerializeField] private bool isInSocket;

    [Header("Game Objects")]
    [SerializeField] private GameObject tablet;
    [SerializeField] private GameObject attach;

    private void Update()
    {
        if(isInSocket == false)
        {
            tablet.transform.position = attach.transform.position;

            //Debug.Log("tablet position = attach position");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isInSocket = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isInSocket = false;
    }
}