using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public int vida;
    public float da�o;

    public abstract void Ataque();
    public abstract void Movimiento();
    
}
