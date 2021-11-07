using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool gameHasEnded = false;

    public float restartDelay = 1f;


    public GameObject completeLevelUI;

    public GameObject GameOverUI;


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }


    public void EndGame()
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            GameOverUI.SetActive(true);
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
