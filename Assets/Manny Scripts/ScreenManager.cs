using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] GameObject menu;
  void ChangeToLayers()
    {

    }

   void ChangeToClimate()
    {

    }

   void ChangeTo2D()
    {

    }

   public void ChangeToQuiz()
    {
        SceneManager.LoadScene(1);
    }
   public void ShowMenu()
    {
        menu.SetActive(!menu.activeSelf);
    }
}
