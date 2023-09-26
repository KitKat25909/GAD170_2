using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ActivityThree : MonoBehaviour
{
    public int strength;
    public int agility;
    public int intelligence;
    public int statPool;
    private int randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        //Set stat pool value
        statPool = 20;
        //Strength stat
        strength = Random.Range(0, statPool);
        statPool = statPool - strength;
        //Agility stat
        agility = Random.Range(0, statPool);
        statPool = statPool - agility;
        //Intelligence stat
        intelligence = Random.Range(0, statPool);
        statPool = statPool - intelligence;
    }

    // Update is called once per frame
    void Update()
    {
        //if we hit the E key on our keyboard
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            //Print stats to console
            Debug.Log("My stats are: ");
            Debug.Log("Strength " + strength);
            Debug.Log("Agility " + agility);
            Debug.Log("Intelligence " +  intelligence);
        }
        
    }
}
