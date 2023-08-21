using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCubeController : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rigidbody>())
        {
            FindObjectOfType<LivesController>().TakeLives();
        }
        else return;

    }
}
