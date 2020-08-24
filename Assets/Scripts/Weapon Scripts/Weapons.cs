using System;
using UnityEngine;

namespace Weapon_Scripts
{
    public class Weapons : MonoBehaviour
    {
        //private GameObject weapon;
        private GameObject _weapons;
        private GameObject _rightHand;
        public int equippedWeapon = 0;
        private readonly String[] _weaponsChoice = {"SRifle","Shotgun","LaserGun","Elite","FusionRanger"};
        private void Awake()
        {
            _rightHand = GameObject.Find("RightHand"); 
            _weapons  = GameObject.Find("Weapons");
            DisableActiveWeaponry();
            ChangeWeapon(_weaponsChoice[equippedWeapon]);
        }

        public void UpgradeRifle()
        {
            if (equippedWeapon < _weaponsChoice.Length-1)
            {
                equippedWeapon++;
            }
            ChangeWeapon(_weaponsChoice[equippedWeapon]);

        }
    
        private void EnableChosenWeaponry(string chosenWeapon)
        {
            Transform[] children = _weapons.transform.GetComponentsInChildren<Transform>(true);
            foreach (Transform gObject in children)
            {
                if (gObject.name == chosenWeapon)
                {
                    gObject.gameObject.SetActive(true); 
                    
                    WeaponPR weaponScript = gObject.GetComponent<WeaponPR>(); 
                    Transform weaponTransform = gObject.transform;
                    weaponTransform.parent = _rightHand.transform;
                    weaponTransform.localPosition = weaponScript.position;
                    weaponTransform.localRotation = Quaternion.Euler(weaponScript.rotation);
                }
            }
        
        }

        private void LoopThroughToDisable(Transform[] weaponsContainer)
        {
            foreach (Transform gObject in weaponsContainer)
            {
                if (gObject.CompareTag("PlayerWeapon"))
                {
                    gObject.gameObject.SetActive(false);
                    gObject.transform.parent = _weapons.transform;
                }
            }
        }

        private void DisableActiveWeaponry()
        {
            Transform[] weaponsInHand = _rightHand.transform.GetComponentsInChildren<Transform>(true);
            Transform[] weaponsInWeapons = _weapons.transform.GetComponentsInChildren<Transform>(true);
            LoopThroughToDisable(weaponsInHand);
            LoopThroughToDisable(weaponsInWeapons);
        }


        public void ChangeWeapon(string weaponName)
        {
            DisableActiveWeaponry();
            EnableChosenWeaponry(weaponName);
        }


  
    }
}
    

