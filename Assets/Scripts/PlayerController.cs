using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _runningSpeed;
    [SerializeField]
    private float _rotateSpeed;
    [SerializeField]
    private float _leftrightSpeed;


    [Space, SerializeField]
    private Transform _player;
    [SerializeField]
    private Animator _playerAnimator;
    [SerializeField]
    private Rigidbody _playerRB;


    private float _oldMousePositionX;
    private float _eulerY;
    public float _jumpSpeed;
    public bool IsGrounded = true;
    public bool OnJump = true;

    void Update()
    {
        //basic movement and camera
        if (Input.GetKey(KeyCode.W))
        {
            _oldMousePositionX = Input.mousePosition.x;
            _playerAnimator.SetBool("isWalking", true);
            Debug.Log("Walk");


        }


        if (Input.GetKey(KeyCode.W))
        {
            Vector3 newPosition = transform.position + transform.forward * _speed * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -0.2f, 0.2f);
            transform.position = newPosition;

            float deltaX = Input.mousePosition.x - _oldMousePositionX;
            _oldMousePositionX = Input.mousePosition.x;

            _eulerY += deltaX;
            _eulerY = Mathf.Clamp(_eulerY, -60, 60);
            transform.eulerAngles = new Vector3(0, _eulerY, 0);
        }


        if (Input.GetKeyUp(KeyCode.W))
        {
            _playerAnimator.SetBool("isWalking", false);
            Debug.Log("Stop");
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            Vector3 newPosition = transform.position + transform.forward * _runningSpeed * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -4f, 4f);
            transform.position = newPosition;
            _playerAnimator.SetBool("isRunning", true);
            Debug.Log("Run");
        }


        //moving Left/Right
        if (Input.GetKey(KeyCode.A))
        {
            _player.transform.Translate(-2 * _leftrightSpeed * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey(KeyCode.D))
        {
            _player.transform.Translate(2 * _leftrightSpeed * Time.deltaTime, 0, 0);
        }

        //looking around
        if (Input.GetKey(KeyCode.E))
        {
            _player.transform.Rotate(0, 10f * _rotateSpeed * Time.deltaTime, 0);


        }

        if (Input.GetKey(KeyCode.Q))
        {
            _player.transform.Rotate(0, -10f * _rotateSpeed * Time.deltaTime, 0);

        }

        //running
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {

            _playerAnimator.SetBool("isRunning", false);
            Debug.Log("Back to walk");
        }

        //jumping
        if (Input.GetKeyDown(KeyCode.Space) && !OnJump)
        {
            OnJump = true;
            _playerRB.AddForce(Vector3.up * _jumpSpeed, ForceMode.Impulse);
            Debug.Log("Jump");
                   
            OnJump = false;

           

        }

        



    } 

    
    



}
