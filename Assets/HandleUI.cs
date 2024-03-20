using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleUI : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject inGame;
    public GamePlay gameplay;

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        inGame.SetActive(false);
    }

    public void beginGame()
    {
        mainMenu.SetActive(false);
        inGame.SetActive(true);
        gameplay.gameHasStarted = true;
        print("HIII");
    }

}
