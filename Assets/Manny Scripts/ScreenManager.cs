using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
   [SerializeField] public  Scene scene;
   void ChangeScene(Scene scene)
    {
        SceneManager.LoadScene(scene.buildIndex);
    }
}
