using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sample_script : MonoBehaviour
{
    public int moveDir = 3;
    public int jumpSpeed = 2;
    public int result;
    void Start()
    {
        print("Pues no te saludo");
    }
    void Update()
    {
        moveDir *= jumpSpeed + 1 * 2;
        moveDir = moveDir * jumpSpeed + 1 * 2;
        result = 2 * 1 + 1;
        print("result es igual a:" + result);
    }
}
