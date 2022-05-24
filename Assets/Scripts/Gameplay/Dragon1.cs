using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon1 : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 5;

    public Barradevida Barradevida;

    void Start()
    {
        Hitpoints = MaxHitpoints;
        Barradevida.SetHealth(Hitpoints, MaxHitpoints);
    }

    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        Barradevida.SetHealth(Hitpoints, MaxHitpoints);
        
        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }

}
