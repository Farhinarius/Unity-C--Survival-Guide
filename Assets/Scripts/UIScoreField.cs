using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreField : MonoBehaviour
{
    public GameObject Player;
    
    Text scoreField;

    void Start() 
    {
        scoreField = GetComponent<Text>();
    }

    void Update()
    {
        CubeController playerController = Player.GetComponent<CubeController>();
        scoreField.text = "Score: " + playerController.getTotalScore().ToString();
    }

    
}
