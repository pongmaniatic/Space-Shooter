using UnityEngine;
using UnityEngine.InputSystem;

namespace Player_Scripts
{
    [RequireComponent(typeof(Animator))]
    public class PlayerMovement : MonoBehaviour
    {

        private InputMaster _inputActions;
        private static readonly int Strafe = Animator.StringToHash("Strafe");
        
        private Vector2 _moveAxis;
    
        private Animator _playerAnimator;
        public float playerSpeed = 10f;
        public float strafeSpeed = 11.0F;
    
    


        private void Awake()
        {
            _playerAnimator = GetComponent<Animator>();
            _inputActions = new InputMaster();
        }

        private void OnEnable()
        {
            _inputActions.Enable();
        }
        
    
        private void OnDisable()
        {
            _inputActions.Disable();
        }

        private void Update()
        {
            _playerAnimator.SetFloat(Strafe,_inputActions.Player.Movement.ReadValue<Vector2>().x);
            transform.position += new Vector3(
                _inputActions.Player.Movement.ReadValue<Vector2>().y * Time.deltaTime * -playerSpeed,
                0,
                _inputActions.Player.Movement.ReadValue<Vector2>().x * Time.deltaTime * strafeSpeed
            );
        }

    


    }
}
