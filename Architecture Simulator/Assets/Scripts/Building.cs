using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public bool isPlaced = false;

    public void InstantiateScaledBuilding(GameObject objectToSpawn)
    {
        objectToSpawn.transform.localScale = new Vector3(10, 10, 10);
        Instantiate(objectToSpawn, new Vector3(transform.position.x, 50f,transform.position.z), Quaternion.identity);
    }

    public void DestroyBuilding()
    {
        Destroy(gameObject);

        Debug.Log("Destroyed");
    }
}
