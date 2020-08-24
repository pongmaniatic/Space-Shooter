using UnityEngine;
using UnityEngine.SceneManagement;

namespace Weapon_Scripts
{
    public class KillBullet : MonoBehaviour
    {

        private GameObject _player;
        public float timeToDestroy = 0.5f;
        public int weaponDamage = 1;


        private void Awake()
        {
            _player = GameObject.FindWithTag("Player");
            Invoke(nameof(Kill),timeToDestroy); 
        }

        private void Kill()
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
                Weapons weaponScript = _player.GetComponent<Weapons>();
                weaponScript.UpgradeRifle();
                Destroy(other.gameObject); 

            }
            
            EnemyBehaviour enemyScript ;
            
            if (other.gameObject.CompareTag("EnemyWaveOne") || other.gameObject.CompareTag("EnemyWaveTwo"))
            {
                enemyScript = other.gameObject.GetComponent<EnemyBehaviour>();
                enemyScript.health -= weaponDamage;
                if (enemyScript.health <= 0)
                {
                    Destroy(other.gameObject);
                }
            }
            if (other.gameObject.CompareTag("Boss"))
            {
                enemyScript = other.gameObject.GetComponent<EnemyBehaviour>();
                enemyScript.health -= weaponDamage;
                if (enemyScript.health <= 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }

                Destroy(gameObject);
            }

            
            // here you change to destroy thing or to make their health lower If object with tag name lets say enemy .. 
            Destroy(gameObject);
        }
    }
}
