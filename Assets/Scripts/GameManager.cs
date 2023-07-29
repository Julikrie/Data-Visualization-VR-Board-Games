using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject welcomeMenu;

    public void Start()
    {
        welcomeMenu.SetActive(true);
    }
    public void LoadStartMenu()
    {
        if (!welcomeMenu.activeSelf)
        {
            welcomeMenu.SetActive(true);
        }
    }
}


