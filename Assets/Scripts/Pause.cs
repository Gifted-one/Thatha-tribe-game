using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public GameObject PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
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
}

        
    
