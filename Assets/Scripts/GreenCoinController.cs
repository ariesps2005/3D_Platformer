using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCoinController : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 360 * Time.deltaTime, 0);

    }

    public void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().AddFiveCoins();
        Destroy(gameObject);
    }
}
