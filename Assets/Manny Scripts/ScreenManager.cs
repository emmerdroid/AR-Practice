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
        SceneManager.LoadScene("EarthLayer");
    }

   public void ChangeToClimate()
    {
        SceneManager.LoadScene("Climate Change");
    }

   public void ChangeToQuiz()
    {
        SceneManager.LoadScene("NewGameLayout");
    }

    public void ChangeToMenu()
    {
        SceneManager.LoadScene("NewMenu");
    }

    public void ChangeToProfile()
    {
        SceneManager.LoadScene("Profile");
    }

    public void ChangetoLeaderBoard()
    {
        SceneManager.LoadScene("LeaderBoard");
    }
   
}
