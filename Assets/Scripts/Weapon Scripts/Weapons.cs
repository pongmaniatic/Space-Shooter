using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    //private GameObject weapon;
    private GameObject weapons;
    private GameObject rightHand;
    public int equippedWeapon = 0;
    private String[] weaponsChoice = {"SRifle","Shotgun","LaserGun","Elite","FusionRanger"};
    private void Awake()
    {
     rightHand = GameObject.Find("RightHand"); 
     weapons  = GameObject.Find("Weapons");
     DisableActiveWeapn();
     ChangeWeapon(weaponsChoice[equippedWeapon]);
     
     
    }

    public void UpgradeRifle()
    {
        if (equippedWeapon < weaponsChoice.Length-1)
        {
            equippedWeapon++;
        }
        ChangeWeapon(weaponsChoice[equippedWeapon]);

    }
    
    private void EnableChosenWeapn(string chosenWeapon)
    {
        Transform[] allchildren = weapons.transform.GetComponentsInChildren<Transform>(true);
        foreach (Transform gObject in allchildren)
        {
            if (gObject.name == chosenWeapon)
            {
                gObject.gameObject.SetActive(true); 
               
                
                //every Weapon has to be positioned and rotated specificly  , pos and rotation are added
                // on every weapon 
                WeaponPR weaponScript = gObject.GetComponent<WeaponPR>(); 
                Transform weaponTransform = gObject.transform;
                weaponTransform.parent = rightHand.transform;
                weaponTransform.localPosition = weaponScript.position;
                weaponTransform.localRotation = Quaternion.Euler(weaponScript.rotation);
            }
        }
        
    }

 

    private void DisableActiveWeapn()
    {
        Transform[] weaponsInHand = rightHand.transform.GetComponentsInChildren<Transform>(true);
        Transform[] weaponsInWeapons = weapons.transform.GetComponentsInChildren<Transform>(true);

        
        foreach (Transform gObject in weaponsInHand)
        {
            if (gObject.CompareTag("PlayerWeapon"))
            {
                gObject.gameObject.SetActive(false);
                gObject.transform.parent = weapons.transform;
            }
        }
        
        
        
        foreach (Transform gObject in weaponsInWeapons)
        {
            if (gObject.CompareTag("PlayerWeapon"))
            {
                gObject.gameObject.SetActive(false);
                gObject.transform.parent = weapons.transform;
            }
        }
    }


    public void ChangeWeapon(string weaponName)
    {
    DisableActiveWeapn();
    EnableChosenWeapn(weaponName);
    }


  
}
    

