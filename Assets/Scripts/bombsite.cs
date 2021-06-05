﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bombsite : MonoBehaviour
{   
    public GameObject panelResult;
   [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == "Player"){
            
            
            if(textBomb.bombValue > 1){

                

            
            panelResult.SetActive(true);             
            }
            else
            {
                textBomb.bombValue = 0;   
            textScore.scoreValue =0;  
        
            textLife.lifeValue -= 1;    


            if(textLife.lifeValue <= 0){
                textScore.scoreValue =0;   
                textLife.lifeValue =3;   
                textBomb.bombValue = 0;   
                print("Game OVer");
                SceneManager.LoadScene("GameOver");
                //  Respawn ke Level 1
            }
         
                
            print("Die");

            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
            SceneManager.LoadScene("RealLevel1");
            }
        }
    }




    void Update(){
        
        
        if(panelResult.activeSelf == true){
        Cursor.visible = true;
        Time.timeScale = 0;
    }
    }
}
