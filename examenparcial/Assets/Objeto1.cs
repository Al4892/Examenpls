using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto1 : Item
{
    // Start is called before the first frame update
    void Start()
    {
        set1();
    }
    void set1()
    {
        Setup("Espada", "Con ella puedes atacar y derrotar monstruos. +45 Daño", 50, Raritys.Comun);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
