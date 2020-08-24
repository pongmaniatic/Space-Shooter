using UnityEngine;
using Weapon_Scripts;

namespace Player_Scripts
{
    public class PlayerInfo : MonoBehaviour
    {
        private InputMaster _inputActions;
        public int playerHealth = 5;
        public float targetTime = 0.3f;


        // Update is called once per frame
        private void Awake()
        {
            _inputActions = new InputMaster();
        }
    
        private void OnEnable()
        {
            _inputActions.Enable();
        }

        private void PlayerShoot()
        {
            GameObject currentWeapon = GameObject.FindWithTag("PlayerWeapon");
            WeaponPR availableWScript = currentWeapon.GetComponent<WeaponPR>();
            availableWScript.PlayerShoot();
        }


        private void OnDisable()
        {
            _inputActions.Disable();
        }

        
        private void TimerEnded()
        {
            PlayerShoot();
            targetTime = 0.3f;
        }
        
        void Update()
        {
            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f)
            {
                TimerEnded();
            }

        
        }



    }
}
