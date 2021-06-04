﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadSceneGameOver(){
        SceneManager.LoadScene("GameOver");
    }

    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void loadSceneUtama()
    {
        SceneManager.LoadScene("MainMenu");
    }
}