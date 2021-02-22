using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Transform player_;
    [SerializeField] Text scoreText;
   

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (Time.time * 100).ToString("0");
    }
    
}
