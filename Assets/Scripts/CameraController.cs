using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _playerTarget;
         
    void Update()
    {
        transform.position = _playerTarget.position; //this object's postition is to be the same as the _playerTarget's position
    }
}
