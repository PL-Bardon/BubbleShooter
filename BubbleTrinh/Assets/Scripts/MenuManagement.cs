using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuManagement : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Game;

    public TextMeshProUGUI pseudo;

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

        Debug.Log(pseudo.text);
    }
}
