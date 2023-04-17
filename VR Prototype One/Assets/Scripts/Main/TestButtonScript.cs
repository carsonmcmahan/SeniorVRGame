using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButtonScript : MonoBehaviour
{
    [SerializeField] private Transform spawnLocation;

    public void SpawnInteractable(GameObject prefab)
    {
        Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
    }
}
