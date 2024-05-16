using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public int vida;
    public float daño;

    public abstract void Ataque();
    public abstract void Movimiento();
    
}
