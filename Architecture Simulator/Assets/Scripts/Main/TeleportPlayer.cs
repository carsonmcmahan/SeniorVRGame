using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private Transform player;

    [Header("Skybox Materials")]
    [SerializeField] private Material[] materials;

    [Header("Audio")]
    public AudioSource mainHub;
    public AudioSource buildSite;

    private void Start()
    {
        RenderSettings.skybox = materials[0];
    }

    public void TeleportToHub(Transform mainHubTeleport)
    {
        player.position = mainHubTeleport.position;
        RenderSettings.skybox = materials[0];
        mainHub.Play();
    }

    public void TeleportToSite(Transform buildSiteTeleport)
    {
        player.position = buildSiteTeleport.position;
        RenderSettings.skybox = materials[1];
        buildSite.Play();
    }
}