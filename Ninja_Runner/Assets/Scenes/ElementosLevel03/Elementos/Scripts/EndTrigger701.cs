using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger701 : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        gameManager.LevelComplete();
    }
}
