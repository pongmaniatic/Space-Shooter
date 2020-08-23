using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInfo : MonoBehaviour
{
    private InputMaster _inputActions;
    public int playerHealth = 100;
    
    // Update is called once per frame
    private void Awake()
    {
        _inputActions = new InputMaster();
    }
    
    private void OnEnable()
    {
        _inputActions.Enable();
    }

    private void Start()
    {
        _inputActions.Player.Shoot.performed += _ => PlayerShoot();
        _inputActions.Player.Shoot.Enable();
    }

    private void PlayerShoot()
    {
        GameObject currentWeapon = GameObject.FindWithTag("PlayerWeapon");
        WeaponPR availableWeapon = currentWeapon.GetComponent<WeaponPR>();
        availableWeapon.PlayerShoot();
    }


    private void OnDisable()
    {
        _inputActions.Disable();
    }

    void Update()
    {
       
    }


}
