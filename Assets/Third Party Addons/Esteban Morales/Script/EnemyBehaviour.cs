using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public int health;
    public int EnemyType;//depending on the type of enemy it gets different health.
    public GameObject sBullet;
    public float targetTime = 10f;

    private void Start()
    {
        if (EnemyType == 0){ health = 5;}// normal enemy 1
        if (EnemyType == 1){ health = 10;}// normal enemy 2
        if (EnemyType == 2){ health = 15;}// normal enemy 3
        if (EnemyType == 3){ health = 20; }// shield enemy 
        if (EnemyType == 4) { health = 40; }// Boss enemy shooting
        if (EnemyType == 5) { health = 40; }// Boss enemy health
        targetTime = Random.Range(5f, 15.0f);//generates a random time to shoot the first time
    }
    void Update()
    {
        //This count down when to shoot
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f){timerEnded();}
    }
    void timerEnded()
    {

        if (EnemyType != 5) 
        {
            EnemyShoot();
        }
        if (EnemyType == 0) { targetTime = Random.Range(2f, 25.0f); }// normal enemy 1
        if (EnemyType == 1) { targetTime = Random.Range(1f, 10.0f); }// normal enemy 2
        if (EnemyType == 4) { targetTime = Random.Range(2f, 10.0f); }// Boss enemy 
    }
    public void EnemyShoot()
    {
        GameObject bullet = transform.gameObject; // this is to make sure that there is a bullet setup for this enemy
        if (bullet != null) { GameObject newBullet = Instantiate(sBullet, transform.position, Quaternion.identity); }//Instantiates a bullet on the drone position, the bullet itself does the rest
    }
}
