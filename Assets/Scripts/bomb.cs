using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bomb : MonoBehaviour
{   

    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    
    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == "Player"){


           
            textScore.scoreValue =0;  
        
            textLife.lifeValue -= 1;    


            if(textLife.lifeValue <= 0){
                textScore.scoreValue =0;   
                textLife.lifeValue =3;   
                print("Game OVer");
                SceneManager.LoadScene("GameOver");
                //  Respawn ke Level 1
            }
         
                
            print("Die");

            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
            
        }
    }
}
