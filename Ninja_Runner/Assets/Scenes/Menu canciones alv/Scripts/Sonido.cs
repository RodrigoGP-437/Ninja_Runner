using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    public AudioSource fuente;
    public AudioClip clip;

    //public int cancion;

    void Start()
    {
        fuente.clip = clip;
    }
    public void Reproducir()
    {
        fuente.Play();
        //switch (cancion)
        //{
            //case 1:
                //fuente.Play();
                //break;
            //case 2:
                //fuente.Play();
                //break;
            //case 3:
                //fuente.Play();
                //break;
            //case 4:
                //fuente.Play();
                //break;
            //case 5:
                //fuente.Play();
                //break;
        //}
    }
    

}
