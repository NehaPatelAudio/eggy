using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public MovementController movement;
    public GameObject endScreen;
    public int Totalbarsneeded = 20;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.numberofBars == Totalbarsneeded)
        {
            print("EndGame");
            endScreen.SetActive(true);
        }

           
    }
}
