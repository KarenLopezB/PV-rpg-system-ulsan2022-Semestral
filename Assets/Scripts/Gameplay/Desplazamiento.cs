using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Desplazamiento : MonoBehaviour
{
    [SerializeField] Vector3 posInicial;
    [SerializeField] Vector3 dirDesplazamiento;
    [SerializeField] [Range(0,1)]float desplazamiento;
    [SerializeField] float periodo = 1;

    void Start()
    {
        posInicial = transform.position;
    }

    void Update()
    {
        float ciclos = Time.time / periodo;
        float tau = Mathf.PI * 2;
        float funcionSeno = Mathf.Sin(tau * ciclos);
        desplazamiento = funcionSeno/2 + 0.5f;
        //Desplazamiento se tiene que mover de forma automatica entre 0 y 1
        transform.position = posInicial + (dirDesplazamiento * desplazamiento);
    }
}
