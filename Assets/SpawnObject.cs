using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Transform Spawnpoint; 
    public GameObject Prefab;
    bool hasSpawned = false;
    public GameObject VictoriaPrefab;
    public Transform VictoriaSpawnpoint;
    
    void OnTriggerEnter(Collider collider)
    {
        MovementController movementController = collider.GetComponent<MovementController>();
        if(movementController != null)
        {
            movementController.target = this;
        }
    }

    public bool Spawn()
    {
        // check if object already spawned
        if(hasSpawned == false)
        {
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
            hasSpawned = true;

            Debug.Log("objectspawned");
            //spawn victoria

            Instantiate(VictoriaPrefab, VictoriaSpawnpoint.position, VictoriaSpawnpoint.rotation);
                


            return true;
            


            
        }
        else
        {
            Debug.Log("hasSpawned");

            return false;
        }
        
    }
}
