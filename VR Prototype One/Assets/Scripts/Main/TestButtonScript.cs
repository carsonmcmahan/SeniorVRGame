using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButtonScript : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnLocation;
    public bool isActive;

    public void ButtonPressed()
    {
        if(isActive == false)
        {
            Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
            isActive = true;
        }
        else if(isActive == true)
        {
            Debug.Log("This object already exists in the world!");
        }
    }
}
