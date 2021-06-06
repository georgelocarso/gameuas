using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textResult : MonoBehaviour
{
    public string level = "Level 1";
    public int scoreValue;
    public Text status;
    public Text score;
    public Button nextLevelBtn;

    
    
    void Start()
    {
        status= GetComponent<Text>();
        score= GetComponent<Text>();
    }

    void Update()
    {
        // print(textScore.scoreValue.ToString());
        // score.text = "Score : "+ textScore.scoreValue.ToString();
        status.text = "Level Passed!";

        nextLevelBtn.interactable= true;

    }

    
}
