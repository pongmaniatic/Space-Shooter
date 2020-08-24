using Player_Scripts;
using UnityEngine;

namespace Enemy_Scripts
{
    public class EnemyKillBullet : MonoBehaviour
    {
        public float timeToDestroy = 5f; //when will it selfdestruct
        public int weaponDamage = 1; // how much damage will it do to the player

        private void Awake()
        {
            Invoke(nameof(Kill), timeToDestroy); //this makes the bullet auto destroy after the set time is reached
        }

        private void Kill()
        {
            Destroy(gameObject); // destroys bullet
        }
        private void OnBecameInvisible()
        {
            Destroy(gameObject);//Destroys the bullet when out of sight of the camera
        }
        public void OnTriggerEnter(Collider other) 
        {

            if (other.gameObject.name == "Granny") //check to see if collided with player
            {

                PlayerInfo enemyScript = other.gameObject.GetComponent<PlayerInfo>(); //get player relevant component
                enemyScript.playerHealth -= weaponDamage;// take life from player
                if (enemyScript.playerHealth <= 0)// this destroys the player if its health is low enough
                {
                    Destroy(other.gameObject);// kills player
                }
                Destroy(gameObject);// destroys bullet once it touches the player
            }
        }
        private void Update()
        {
            var transform1 = transform;
            transform1.position += transform1.right * (Time.deltaTime * 6); // this makes the bullets go down
        }
    }
}
