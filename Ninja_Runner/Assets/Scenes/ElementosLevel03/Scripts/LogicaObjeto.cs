using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaObjeto : MonoBehaviour
{
    public bool destruirConCursor;
    public bool destruirAutomatico;
    public MovimientoJugador movimientoJugador;

    public int tipo;

    //1 crece
    //2 aumenta velocidad
    //3 aumenta salto
    //4 lento
    // Start is called before the first frame update

    void Start()
    {
        movimientoJugador = GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoJugador>();
    }

    // Update is called once per frame

    void Update()
    {

    }


    public void Efecto()
    {
        switch (tipo)
        {
            case 1:
                movimientoJugador.gameObject.transform.localScale = new Vector3(3, 3, 3);
                break;
            case 2:
                movimientoJugador.velocidadMovimiento += 2;
                break;
            case 3:
                movimientoJugador.fuerzaDeSalto += 1;
                break;
            case 4:
                movimientoJugador.velocidadMovimiento -= 3;
                break;


            default:
                Debug.Log("sin efecto");
                break;
        }
    }
}