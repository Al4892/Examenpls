using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto1 : Item
{
    // Start is called before the first frame update
    void Start()
    {
        //Raritys xd= Raritys.iron;
        Setup("Espada", "Con ella puedes atacar y derrotar monstruos. +45 Daño", 50, Raritys.Comun);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
