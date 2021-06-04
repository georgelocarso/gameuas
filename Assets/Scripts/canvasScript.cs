using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{

    public  GameObject panelGameOver;
    // Start is called before the first frame update
    void Start()
    {
        panelGameOver.SetActive(false);
    }

    

    public void NewGame(){
        panelGameOver.SetActive(false);
    }
}
