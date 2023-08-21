using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FallCollider : MonoBehaviour
{

    [SerializeField]
    private Canvas _gameOverScreen;

    private void Start()
    {
        _gameOverScreen.enabled = false;
    }
     
        public void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Rigidbody>())
        {
            FindObjectOfType<LivesController>().Die();
            //gameover
            _gameOverScreen.enabled = true;
            Debug.Log("you lost");


        }
    }

}
