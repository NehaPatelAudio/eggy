using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public MovementController movement;
    public GameObject endScreen;
    


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.numberofBars == 1)
        {
            print("EndGame");
            endScreen.SetActive(true);
        }

           
    }
}
