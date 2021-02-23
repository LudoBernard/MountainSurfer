using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Transform player_;
    public Text scoreText;
    

    void Update()
    {
        scoreText.text = (Time.time * 100).ToString("0");
    }
    
}
