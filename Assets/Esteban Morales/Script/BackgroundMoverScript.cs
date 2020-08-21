using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoverScript : MonoBehaviour
{
    // The purpose of this Script is t o generate an infinit randombly generated map, to do that, 
    // I will create new pieces of map and destroy old ones creating the illusion if infinit.

    public GameObject floor1;
    public GameObject floor2;
    public GameObject floor3;
    public GameObject floor4;

    public int randomFloor = 0;

    public float spwanTime = 1.0f;

    void Update()
    {
        spwanTime -= Time.deltaTime;
        if (spwanTime <= 0.0f)
        {
            randomFloor = Random.Range(1, 4);
            spwanTime = 1.0f;
            timerEnded();
        }

    }

    void timerEnded()
    {
        if (randomFloor == 1) { Instantiate(floor1, new Vector3(-25, 0, 0), Quaternion.identity); }
        if (randomFloor == 2) { Instantiate(floor2, new Vector3(-25, 0, 0), Quaternion.identity); }
        if (randomFloor == 3) { Instantiate(floor3, new Vector3(-25, 0, 0), Quaternion.identity); }
        if (randomFloor == 4) { Instantiate(floor4, new Vector3(-25, 0, 0), Quaternion.identity); }
    }
}
 


