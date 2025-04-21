using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    bool active;
    Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }


    void Update()
    {
        if (Input.GetKeyDown("p"))
            active = !active;
        canvas.enabled = active;
        Time.timeScale = (active) ? 0 : 1f;
    }
}
