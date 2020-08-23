using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPR : MonoBehaviour
{
   public Vector3 position = new Vector3();
   public Vector3 rotation = new Vector3();
   public GameObject sBullet;

   private void Awake()
   {


   }

   public void PlayerShoot()
   {
      

      GameObject bullet = transform.GetChild(1).gameObject;
      
      
         if (bullet != null)
         {
            Vector3 position = bullet.transform.position;
            var localRotation = bullet.transform.rotation;
            GameObject newBullet = Instantiate(sBullet, position, Quaternion.identity);
            //newBullet.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f); // change its local scale in x y z format
            newBullet.transform.parent = bullet.transform;
            newBullet.transform.localPosition = position;
            newBullet.transform.rotation = localRotation;
   
            newBullet.transform.parent = null;
            newBullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * 15, ForceMode.VelocityChange);
         }
      
   }
   
}
