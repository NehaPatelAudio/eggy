using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBar : MonoBehaviour

{
    public MovementController movement;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
        
    {
        Debug.Log("interacting with" + collider.name);
        MovementController movementController = collider.GetComponent<MovementController>();
        if (movementController != null)
        {
            movementController.goldbar = this;

            Debug.Log("setting myself as to player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
