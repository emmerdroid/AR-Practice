using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Login2Lobby : MonoBehaviour
{
    // Start is called before the first frame update
    public void Lgn2Lbby()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void Lbby2Lgn()
    {
        SceneManager.LoadScene("Tuffy login");
    }

    public void Lbby2Pfl()
    {
        SceneManager.LoadScene("Profile");
    }

    public void Pfl2Lbby()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void SgnUp2Lbby()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void Lgn2SgnUp()
    {
        SceneManager.LoadScene("Sign up");
    }

    public void SgnUp2Lgn()
    {
        SceneManager.LoadScene("Tuffy login");
    }
    //Code Added 8/11/2022 from Emmanuel, to go to AR scene
    public void JoinScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
