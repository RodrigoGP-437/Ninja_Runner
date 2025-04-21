using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject levelCompleteUI;

    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelComplete()
    {
        levelCompleteUI.SetActive(true);
    }
}
