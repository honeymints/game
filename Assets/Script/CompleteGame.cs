using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteGame : MonoBehaviour
{
    public GameObject FinishGameMenu;

    private void OnEnable()
    {
        PlayerController.FinishGame += EnableFinishGameMenu; //wtf is that
    }
    private void OnDisable()
    {
        PlayerController.FinishGame -= EnableFinishGameMenu;
    }

    public void EnableFinishGameMenu()
    {
        FinishGameMenu.SetActive(true);
    }

}


