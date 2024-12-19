using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coin;
    public AudioSource audioSource;
    public AudioClip coinCollect;
  
    public void CollectCoins()
    {
        coin++; // Sumamos 1 a la cantidad de monedas total
        //audioSource.PlayOneShot(coinCollect); //Reproducimos Audio
        print("Collected Coins:" + coin); 
        //Mostramos por la terminal la cantidad de monedas
    }
}