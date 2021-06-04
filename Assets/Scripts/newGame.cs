using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour
{
    void restart(){
        textScore.scoreValue = 0;     
        textLife.lifeValue = 3;   
    }
}
