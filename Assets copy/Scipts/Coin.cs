using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Add to the player's score
//Destroy the coin 

public class Coin : MonoBehaviour
{
    public float turnSpeed=90f;


  
    void Update()
    {
        transform.Rotate(0,0,turnSpeed*Time.deltaTime);
    }
}
