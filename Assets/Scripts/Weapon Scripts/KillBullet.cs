using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBullet : MonoBehaviour
{

    private GameObject playerRef;
    public float timeToDestroy = 0.5f;
    public int weaponDamage = 1;

    
    void Awake()
    {
        playerRef = GameObject.FindWithTag("Player");
        Invoke(nameof(Kill),timeToDestroy); 
    }

    void Kill()
    {
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "AmmoBox")
        {
            Weapons wScript = playerRef.GetComponent<Weapons>();
            wScript.UpgradeRifle();
            Destroy(other.gameObject); 

        }
        
        // weaponDamage is different for each bullet prefab 
        // if (other.gameObject.name == "enemy") .. or use tag for all your enemies created 
        // Other will be the enemy that we hit  . do enemy.health - weapon damage and if its below 0 than destroy else
        // just retract - damage . 
        
        
        
        
// here you change to destroy thing or to make their health lower If object with tag name lets say enemy .. 
        Destroy(gameObject);
    }
}
