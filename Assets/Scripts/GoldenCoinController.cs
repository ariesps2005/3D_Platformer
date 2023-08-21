using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GoldenCoinController : MonoBehaviour
{
    [SerializeField]
    private Canvas _winnerScreen;

    [SerializeField]
    private Transform _player;

    public Vector3 targetRotation;


    void Start()
    {
        _winnerScreen.enabled = false;
    }

    void Update()
    {
        transform.Rotate(0, 360 * Time.deltaTime, 0);

    }

    public void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().Add20Coins();
        Destroy(gameObject);
        StartCoroutine(RotatePlayer(Quaternion.Euler(targetRotation), 5));
        _winnerScreen.enabled = true;

    }

    public IEnumerator RotatePlayer(Quaternion endValue, float duration)
    {
        float time = 1;
        Quaternion startValue = transform.rotation;

        while (true)
        {
            _player.transform.rotation = Quaternion.Lerp(startValue, endValue, time / duration);

            time += Time.deltaTime;

            //_player.transform.Rotate(0f, 180f, 0f);
            yield return null;
        }
    }
}
