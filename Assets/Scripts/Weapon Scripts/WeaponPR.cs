using UnityEngine;

namespace Weapon_Scripts
{
   public class WeaponPR : MonoBehaviour
   {
      public Vector3 position ;
      public Vector3 rotation ;
      public GameObject sBullet;


      public void PlayerShoot()
      {
         GameObject bullet = transform.GetChild(1).gameObject;
         if (bullet != null)
         {
            // Instantiate a new Bullet , fix its Pos and Rot then use force to shoot
            
            Vector3 transformPosition = bullet.transform.position;
            var localRotation = bullet.transform.rotation;
            GameObject newBullet = Instantiate(sBullet, transformPosition, Quaternion.identity);

            newBullet.transform.parent = bullet.transform;
            newBullet.transform.localPosition = transformPosition;
            newBullet.transform.rotation = localRotation;
   
            newBullet.transform.parent = null;
            newBullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * 15, ForceMode.VelocityChange);
         }
      }
   }
}
