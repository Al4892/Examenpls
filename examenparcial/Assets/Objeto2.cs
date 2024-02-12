using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto2 : Item
{
    // Start is called before the first frame update
    void Start()
    {
        set2();
    }
    void set2()
    {
        Setup("Pocion", "Puedes usarla para recuperar vida. +50 vida", 1, Raritys.Raro);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
