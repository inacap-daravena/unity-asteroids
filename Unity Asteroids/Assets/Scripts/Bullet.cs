using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidadBala = 500f;
    public float tiempoMaximo = 10f;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Proyectar(Vector2 direccion)
    {
        rb.AddForce(direccion * velocidadBala);

        Destroy(this.gameObject, this.tiempoMaximo);
    }
}
