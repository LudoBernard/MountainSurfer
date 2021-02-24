using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
   [SerializeField] private GameObject mainCanvas;

   public void PlayGame()
   {
      //mainCanvas.SetActive(true);
      SceneManager.LoadScene("LudoScene");
   }

   public void QuitGame()
   {
      Application.Quit();
   }
}
