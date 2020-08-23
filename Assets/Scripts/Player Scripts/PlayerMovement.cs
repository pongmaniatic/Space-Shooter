using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{

    private Vector2 _moveAxis;
    
    private Animator playerAnimator;
    public float playerSpeed = 10f;
    public float strafeSpeed = 11.0F;
    
    
    private InputMaster _inputActions;
    private void Awake()
    {
       playerAnimator = GetComponent<Animator>();
       _inputActions = new InputMaster();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
    }


    private void Start()
    {
        _inputActions.Player.Movement.performed +=  OnMovement;
        _inputActions.Player.Movement.Enable();
    }


    private void OnMovement(InputAction.CallbackContext obj)
    {
        _moveAxis = obj.ReadValue<Vector2>();
    }
    
    
    private void OnDisable()
    {
        _inputActions.Disable();
    }

    private void Update()
    {
        playerAnimator.SetFloat("Strafe",_inputActions.Player.Movement.ReadValue<Vector2>().x);
        transform.position += new Vector3(
            _inputActions.Player.Movement.ReadValue<Vector2>().y * Time.deltaTime * -playerSpeed,
            0,
            _inputActions.Player.Movement.ReadValue<Vector2>().x * Time.deltaTime * strafeSpeed
        );
    }

    


}
