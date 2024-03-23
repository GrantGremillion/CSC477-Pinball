using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleUI : MonoBehaviour
{
    public GamePlay gameScript;
    public GameObject mainMenu;
    public GameObject inGame;
    public GameObject gameOver;
    public GamePlay gameplay;
    public Camera cam;
    public Transform cameraPosition;
    public GameObject ocean;

    void Awake()
    {
        mainMenu.SetActive(true);
        inGame.SetActive(false);
        gameOver.SetActive(false);
        ocean.SetActive(true);
    }

    public void beginGame()
    {
        mainMenu.SetActive(false);
        inGame.SetActive(true);
        gameplay.gameHasStarted = true;
        cam.transform.SetPositionAndRotation(cameraPosition.position, cameraPosition.rotation);
    }

    public void endGame()
    {
        inGame.SetActive(false);
        gameOver.SetActive(true);
    }

    public void restartGame()
    {
        inGame.SetActive(true);
        gameOver.SetActive(false);
        gameScript.gameHasStarted = true;
        gameScript.readyToLaunch = true;
        gameScript.lives = 5;
        gameScript.score = 0;
        cam.transform.SetPositionAndRotation(cameraPosition.position, cameraPosition.rotation);
        
    }

}
