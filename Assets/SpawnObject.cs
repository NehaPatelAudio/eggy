using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Transform Spawnpoint; 
    public GameObject Prefab;
    bool hasSpawned = false;
    public GameObject VictoriaPrefab;
    public Transform VictoriaSpawnpoint2;
    public Transform VictoriaSpawnpoint3;
    public Transform VictoriaSpawnpoint4;
    public Transform VictoriaSpawnpoint5;
    public Transform VictoriaSpawnpoint6;
    public Transform VictoriaSpawnpoint7;
    public Transform VictoriaSpawnpoint8;
    public Transform VictoriaSpawnpoint9;
    public Transform VictoriaSpawnpoint10;
    

    public Transform VictoriaSpawnpoint;

    public MovementController movementController;
    
    void OnTriggerEnter(Collider collider)
    {
         movementController = collider.GetComponent<MovementController>();
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

            if (VictoriaSpawnpoint != null)
            {
                GameObject VictoriaSpawn = Instantiate(VictoriaPrefab, VictoriaSpawnpoint.position, VictoriaSpawnpoint.rotation);
                VictoriaMove victoriaMove = VictoriaSpawn.GetComponent<VictoriaMove>();
                victoriaMove.movement = movementController;

            }

           
            if( VictoriaSpawnpoint2 != null)
            {
               GameObject VictoriaSpawn = Instantiate(VictoriaPrefab, VictoriaSpawnpoint2.position, VictoriaSpawnpoint2.rotation);
                VictoriaMove victoriaMove = VictoriaSpawn.GetComponent<VictoriaMove>();
                victoriaMove.movement = movementController; 
            }


            if (VictoriaSpawnpoint3 != null)
            {
                GameObject VictoriaSpawn = Instantiate(VictoriaPrefab, VictoriaSpawnpoint3.position, VictoriaSpawnpoint3.rotation);
                VictoriaMove victoriaMove = VictoriaSpawn.GetComponent<VictoriaMove>();
                victoriaMove.movement = movementController;
            }

            if (VictoriaSpawnpoint4 != null)
            {
                GameObject VictoriaSpawn = Instantiate(VictoriaPrefab, VictoriaSpawnpoint4.position, VictoriaSpawnpoint4.rotation);
                VictoriaMove victoriaMove = VictoriaSpawn.GetComponent<VictoriaMove>();
                victoriaMove.movement = movementController;
            }

            if (VictoriaSpawnpoint5 != null)
            {
                GameObject VictoriaSpawn = Instantiate(VictoriaPrefab, VictoriaSpawnpoint5.position, VictoriaSpawnpoint5.rotation);
                VictoriaMove victoriaMove = VictoriaSpawn.GetComponent<VictoriaMove>();
                victoriaMove.movement = movementController;
            }

            if (VictoriaSpawnpoint6 != null)
            {
                GameObject VictoriaSpawn = Instantiate(VictoriaPrefab, VictoriaSpawnpoint6.position, VictoriaSpawnpoint6.rotation);
                VictoriaMove victoriaMove = VictoriaSpawn.GetComponent<VictoriaMove>();
                victoriaMove.movement = movementController;
            }

            if (VictoriaSpawnpoint7 != null)
            {
                GameObject VictoriaSpawn = Instantiate(VictoriaPrefab, VictoriaSpawnpoint7.position, VictoriaSpawnpoint7.rotation);
                VictoriaMove victoriaMove = VictoriaSpawn.GetComponent<VictoriaMove>();
                victoriaMove.movement = movementController;
            }

            if (VictoriaSpawnpoint8 != null)
            {
                GameObject VictoriaSpawn = Instantiate(VictoriaPrefab, VictoriaSpawnpoint8.position, VictoriaSpawnpoint8.rotation);
                VictoriaMove victoriaMove = VictoriaSpawn.GetComponent<VictoriaMove>();
                victoriaMove.movement = movementController;
            }

            if (VictoriaSpawnpoint9 != null)
            {
                GameObject VictoriaSpawn = Instantiate(VictoriaPrefab, VictoriaSpawnpoint9.position, VictoriaSpawnpoint9.rotation);
                VictoriaMove victoriaMove = VictoriaSpawn.GetComponent<VictoriaMove>();
                victoriaMove.movement = movementController;
            }

            if (VictoriaSpawnpoint10 != null)
            {
                GameObject VictoriaSpawn = Instantiate(VictoriaPrefab, VictoriaSpawnpoint10.position, VictoriaSpawnpoint10.rotation);
                VictoriaMove victoriaMove = VictoriaSpawn.GetComponent<VictoriaMove>();
                victoriaMove.movement = movementController;
            }


            return true;
            


            
        }
        else
        {
            Debug.Log("hasSpawned");

            return false;
        }
        
    }
}
