using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject teleportSite;
    [SerializeField] private GameObject teleportMainHub;

    [Header("Skybox Materials")]
    [SerializeField] private Material[] materials;

    [Header("Audio")]
    public AudioSource mainHub;
    public AudioSource buildSite;

    private void Start()
    {
        RenderSettings.skybox = materials[0];
    }

    public void TeleportToHub()
    {
        player.transform.position = teleportMainHub.transform.position;
        RenderSettings.skybox = materials[0];
        mainHub.Play();
    }

    public void TeleportToSite()
    {
        player.transform.position = teleportSite.transform.position;
        RenderSettings.skybox = materials[1];
        buildSite.Play();
    }

    
}