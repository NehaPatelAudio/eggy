using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBar : MonoBehaviour
    

{
    public int goldbarstoadd = 4;
    public MovementController movement;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
        
    {
        
        MovementController movementController = collider.GetComponent<MovementController>();
        if (movementController != null)
        {
            movementController.goldbar = this;

           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
