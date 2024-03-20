using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleUI : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject inGame;
    public GamePlay gameplay;

    void Awake()
    {
        mainMenu.SetActive(true);
        inGame.SetActive(false);
    }

    public void beginGame()
    {
        mainMenu.SetActive(false);
        inGame.SetActive(true);
        gameplay.gameHasStarted = true;
    }

}
