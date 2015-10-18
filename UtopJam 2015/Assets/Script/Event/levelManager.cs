using UnityEngine;
using System.Collections;

public class levelManager : MonoBehaviour
{

    public GameObject Menu;
    public GameObject MenuLogo;
    public bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown("escape") && !isPaused)
        {
            StartPause();
        }

    }

    public void LoadLevel(int id)
    {
        Debug.Log("Loading level: " + id);
        Application.LoadLevel(id);
    }
    public void QuitGame()
    {
        Debug.Log("Bye!");
        Application.Quit();
    }
    public void StartPause()
    {
        Debug.Log("Have a Break!");
        Menu.SetActive(true);
        MenuLogo.SetActive(true);
        isPaused = true;
        Time.timeScale = 0;
    }
    public void LeavePause()
    {
        Debug.Log("Have a Kit-Kat!");
        Menu.SetActive(false);
        MenuLogo.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
    }
}