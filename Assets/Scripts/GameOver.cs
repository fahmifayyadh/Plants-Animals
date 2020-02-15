using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    // Update is called once per frame

    public void Play()
    {
            SceneManager.LoadScene("Gameplay ref");
      
    }

    public void exit()
    {
        Application.Quit();
    }
}
