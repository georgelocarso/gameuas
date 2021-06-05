using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textBomb : MonoBehaviour
{

    public static int bombValue = 0;

    public Text bomb;


    // Start is called before the first frame update
    void Start()
    {
       bomb = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        bomb.text = "Bomb : "+bombValue+"/5";
    }
}
