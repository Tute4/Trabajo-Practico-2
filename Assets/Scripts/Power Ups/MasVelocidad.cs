using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasVelocidad : PowerUp
{
    public float AumentoDeVelocidad = 2f;

    public override void ActivarPowerUp()
    {
        //Destruye el objeto al colisionar
    }

    public void Rapidez()
    {
        //Aumenta la velocidad del player x2 al tomar el powerup
    }
}
