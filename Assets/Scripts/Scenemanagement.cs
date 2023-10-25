using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenemanagement : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject PauseMenu;
    //public AudioSource audioSource;
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Actual Game", LoadSceneMode.Single);
        //audioSource.Play();
    }
    public void loadSettings()
    {
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);
    }

    public void Start()
    {
        PauseMenu.SetActive(false);
    }
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;
        }
        if (PauseMenu.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                PauseMenu.SetActive(false);
                SceneManager.LoadScene("Menu");
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                PauseMenu.SetActive(false);
                Time.timeScale = 1.0f;
                SceneManager.LoadScene("Actual Game");
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                PauseMenu.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }


    }

    public void LoadHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay", LoadSceneMode.Single);
    }
}
