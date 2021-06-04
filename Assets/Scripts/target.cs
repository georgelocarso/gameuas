using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{   

 
    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == "Player"){
            print("Picked Up");
            textScore.scoreValue += 100; 
            gameObject.SetActive(false);
            // Destroy(gameObject);
        }
    }
}
