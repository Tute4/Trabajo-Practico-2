using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour
{
    public float velocidad;
    public float vida;
    public float salto;
    protected Rigidbody2D rb;
    protected bool suelo;
    protected int puntos;

    protected virtual void Start()
    {
        // Toma el rigibody al iniciar
    }

    protected virtual void Update()
    {
        // Lógica de movimiento del jugador
    }

    protected abstract void Saltar();

    protected virtual void OnCollsionEnter2D(Collision2D collision)
    {
        //detectar las colisiones para que el jugador pierda vida 
    }
    protected void AumentarPuntuacion()
    {
        //aumenta puntos
    }
}
