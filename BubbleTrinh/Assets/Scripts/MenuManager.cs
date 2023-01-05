using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Game;

    void Start()
    {
        getMenu();
    }
    public void getMenu()
    {
        Game.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void getGame()
    {   
        Game.SetActive(true);
        MainMenu.SetActive(false);
    }
}
