using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelselect : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene("uh");
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene("TWO");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}