using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float bounds = 3;

    void Update()
    {
        PlayerBoundries();
    }

    private void PlayerBoundries()
    {
        if(transform.position.x <= -bounds)
        {
            transform.position = new Vector3(-bounds, transform.position.y, transform.position.z);
        }

        if(transform.position.z <= -bounds)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -bounds);
        }

        if (transform.position.x >= bounds)
        {
            transform.position = new Vector3(bounds, transform.position.y, transform.position.z);
        }

        if (transform.position.z >= bounds)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, bounds);
        }
    }
}
