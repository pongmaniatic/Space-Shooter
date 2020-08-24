using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMovement : MonoBehaviour
{
    public float Lifespan = 8.0f;
 
    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * 5;
        Lifespan -= Time.deltaTime;
        if (Lifespan <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        Destroy(gameObject);
    }

}