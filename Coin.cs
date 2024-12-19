using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//<>(){}[]

public class Coin : MonoBehaviour
{
    //Utilizamos OnTrigerEnter para detectar un collider(una colision)
    void OnTriggerEnter(Collider other)//Lo que pone aqui, se refiere a lo que estamos colisionanado
    {
        Player player = other.GetComponent<Player>(); //Guardamos la referencia del objeto que hemos colisionado
        player.CollectCoins(); //como estamos accediendo al player, podemos usar sus metodos publicos
        Destroy(player);
    }
}
