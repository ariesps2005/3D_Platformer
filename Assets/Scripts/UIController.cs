using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private CoinManager _coincontroller;

    [SerializeField]
    private LivesController _livesController;
    
    [SerializeField]
    private TMP_Text _coinsText;

    [SerializeField]
    private TMP_Text _livesText;

    private void Start()
    {
        
    }

    private void Update()
    {
        _coinsText.text = _coincontroller.PickedupCoins.ToString();

        _livesText.text = _livesController.Lives.ToString();
    }

}
