using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Bloque Global
    public int health = 5;                 //La vida que tiene el NPC
    int level = 1;                  //El nivel del enemigo
    public float speed = 2.5f;             //La Velocidad del enemigo

    void Start()
    {
        //Bloque local ejecución
        health += level;            //Nos suma el nivel que tenemos a la vida
        print("Vidas: " + health);  //Muestra la vida que tiene el enemigo
    }

  
    void Update()
    {
        //Crear vector3 para guardar la posicion del npc
        Vector3 newPos = transform.position;
        //Cambiar la posicion en el eje z acorde a la velocidad del enemigo
        newPos.z += speed * Time.deltaTime;
       //apliqueis el movimiento
       transform.position = newPos;
    }
}
