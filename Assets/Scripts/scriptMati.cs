using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMati : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;


    void onTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player"){
        {   
            print("Trig");
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }

    }
}
}
