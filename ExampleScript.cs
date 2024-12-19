using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    private int coins = 0;
  

    
    void Start()
    {
        
    }

    
    void Update()
    {
        CollectCoins();
    }

    public void CollectCoins() // metodo
    {
        coins++;
        //coins += 1;
        //coins = coins + 1;
        print("Collected Coins: " + coins);
    }
}



