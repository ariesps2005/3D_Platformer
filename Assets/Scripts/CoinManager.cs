using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int PickedupCoins;
    
    // Start is called before the first frame update
    

    public void AddCoins()
    {
        PickedupCoins++;
    }

    public void AddFiveCoins()
    {
        PickedupCoins += 5;
    }

    public void Add20Coins()
    {
        PickedupCoins += 20;
    }


}
