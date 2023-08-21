using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesController : MonoBehaviour
{
    public int Lives;

    [SerializeField]
    private Canvas _gameOverScreen;

    private void Start()
    {
        _gameOverScreen.enabled = false;
    }


    public void TakeLives()
    {
        Lives -= 1;

        if (Lives < 1)
        {
            _gameOverScreen.enabled = true;
            Time.timeScale = 0f;
            Debug.Log("you lost");
        }
    }

    public void Die()
    {
        Lives = 0;

    }

    public void GetLife()
    {
        Lives += 1;
    }




}
