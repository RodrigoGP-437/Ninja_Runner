using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    //[SerializeField] private float runSpeed;
    //[SerializeField] private float x, y;

    [SerializeField] public float velocidadMovimiento;
    //public float velocidadRotacion = 200.0f;
    public float x;
    [SerializeField] private float y;
    //private float y;
    private Animator anim;

    public Rigidbody rb;
    public float fuerzaDeSalto = 8f;
    public bool puedoSaltar;

    //private void //Start()
    void Start()
    {
        puedoSaltar = false;
        anim = GetComponent<Animator>();
        //anim = GetComponentInChildren<Animator>();
    }

    //private void FixedUpdate()
    //void Update()
    void FixedUpdate()
    {
        //transform.Translate(x * Time.deltaTime * runSpeed, 0, 0);
        //transform.Translate(0, 0, y * Time.deltaTime * runSpeed);
        transform.Translate(x * Time.deltaTime * velocidadMovimiento, 0, 0);
        //transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);


    }
    private void Update()
    {
        x = Input.GetAxis("Horizontal");
        //y = Input.GetAxis("Vertical");

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", 1);

        if (puedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("salte", true);
                rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
            }
            anim.SetBool("tocoSuelo", true);
        }
        else
        {
            EstoyCayendo();
        }
    }
    public void EstoyCayendo()
    {
        anim.SetBool("tocoSuelo", false);
        anim.SetBool("salte", false);
    }
}