using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    /// <summary>
    /// Keeps track of all the scene management for the buttons 
    /// to go between different scenes.
    /// </summary>
  public void ChangeToLayers()
    {
        SceneManager.LoadScene(0);
    }

   public void ChangeToClimate()
    {
        SceneManager.LoadScene(4);
    }

   public void ChangeToQuiz()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeToMenu()
    {
        SceneManager.LoadScene(5);
    }
   
}
