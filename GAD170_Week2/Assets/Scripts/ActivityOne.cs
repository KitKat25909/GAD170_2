using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ActivityOne : MonoBehaviour
{
    public string favGame = "Hogwarts Legacys"; //variable for favourite game
    public int hoursPlayed = 80; //variable for hours played
    public float purchaseCost = 119.95f; //variable for purchase cost
    // Start is called before the first frame update
    void Start()
    { 
        Debug.Log("My favourite game is " 
            + favGame + ", I have played it for " 
            + hoursPlayed + ", it cost me $" 
            +purchaseCost + ", My dollars per hour is: " 
            + purchaseCost/hoursPlayed);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
