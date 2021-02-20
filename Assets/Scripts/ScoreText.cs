using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Transform player_;
    private Text scoreText_;
   

    // Update is called once per frame
    void Update()
    {
        scoreText_.text = (player_.position.z * 100).ToString("0");
    }
}
