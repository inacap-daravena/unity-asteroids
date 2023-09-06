using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadGiro = 1.0f;
    public float velocidadImpulso = 1.0f;

    private Rigidbody2D rb;
    private bool impulsando;
    private float direccion;

    // Start: es ejecutada el primer cuadro desde la habilitación del script.
    void Start()
    {
        
    }

    // Awake: es ejecutada el primer cuadro sin depender de la habilitación del script.
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update: es ejecutada una vez por cuadro.
    void Update()
    {
        if (Input.GetAxis("Horizontal") < 0f)
        {
            direccion = 1f;
        } else if (Input.GetAxis("Horizontal") > 0f)
        {
            direccion = -1f;
        } else
        {
            direccion = 0.0f;
        }

        if (Input.GetButton("Jump")) impulsando = true;
        else impulsando = false;
    }

    // Update: es ejecutada según la frecuencia del motor físico.
    void FixedUpdate()
    {
        if (velocidadGiro != 0f) rb.AddTorque(velocidadGiro * direccion);

        if (impulsando) rb.AddForce(this.transform.up * velocidadImpulso);
    }
}
