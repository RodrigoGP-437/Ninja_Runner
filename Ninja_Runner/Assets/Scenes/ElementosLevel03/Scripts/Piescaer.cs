using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piescaer : MonoBehaviour
{
    public MovimientoJugador movimientoJugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        movimientoJugador.puedoSaltar = true;
    }

    private void OnTriggerExit(Collider other)
    {
        movimientoJugador.puedoSaltar = false;
    }
}
