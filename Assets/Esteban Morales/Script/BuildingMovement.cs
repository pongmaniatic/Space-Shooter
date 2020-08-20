using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMovement : MonoBehaviour
{
    public float Lifespan = 10.0f;
 
    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * 5;
        Lifespan -= Time.deltaTime;
        Debug.Log(Lifespan);
        if (Lifespan <= 0.0f)
        {
            Debug.Log("destroy");
            timerEnded();
        }

    }

    void timerEnded()
    {
        Destroy(gameObject);
    }

}