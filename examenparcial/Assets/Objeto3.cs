using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto3 : Item
{
    // Start is called before the first frame update
    void Start()
    {
        set3();
    }
    void set3()
    {
        Setup("Estrella sagrada", "Revive con todo los puntos de vida y magicos y aumenta todas las caracteristicas", 1, Raritys.Legenadrio);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
