
using UnityEngine;

public class CoinController : MonoBehaviour
{


    
    void Update()
    {
        transform.Rotate(0, 360 * Time.deltaTime, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().AddCoins();
        
        Destroy(gameObject);
    }

}
