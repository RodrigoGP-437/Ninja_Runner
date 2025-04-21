using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionsJugador : MonoBehaviour
{
    public MovimientoJugador desactivarMovimiento;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacles")
        {
            desactivarMovimiento.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
