﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bombsite : MonoBehaviour
{   

 
    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == "Player"){
            print("Level Up");

            SceneManager.LoadScene("Level2");            
            gameObject.SetActive(false);
            // Destroy(gameObject);
        }
    }
}
