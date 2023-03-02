using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject teleportSite;
    [SerializeField] private GameObject teleportMainHub;

    [Header("Audio")]
    public AudioSource mainHub;
    public AudioSource buildSite;

    public void TeleportToSite()
    {
        player.transform.position = teleportSite.transform.position;
        buildSite.Play();
    }

    public void TeleportToHub()
    {
        player.transform.position = teleportMainHub.transform.position;
        mainHub.Play();
    }
}