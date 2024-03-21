using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleUI : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject inGame;
    public GamePlay gameplay;
    public Camera cam;
    public Transform cameraPosition;
    public GameObject ocean;

    void Awake()
    {
        mainMenu.SetActive(true);
        inGame.SetActive(false);
        ocean.SetActive(true);
    }

    public void beginGame()
    {
        mainMenu.SetActive(false);
        inGame.SetActive(true);
        gameplay.gameHasStarted = true;
        cam.transform.SetPositionAndRotation(cameraPosition.position, cameraPosition.rotation);
    }

}
