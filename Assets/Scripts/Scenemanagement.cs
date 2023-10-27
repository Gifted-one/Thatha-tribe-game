using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenemanagement : MonoBehaviour
{

    // Start is called before the first frame update
    
    //public AudioSource audioSource;
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
        //audioSource.Play();
    }
    public void loadSettings()
    {
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);
    }

    public void LoadHowToPlay()
    {
        SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
    }
}
