using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Item : MonoBehaviour
{
    public enum Raritys
    {
        Base = 0,
        wood = 1,
        stone = 2,
        iron = 3,
        gold = 4,
        diamond = 5
    }
    public class Inventarios : MonoBehaviour
    {
        public Sprite icons;
        public Raritys Rareza;
        
        string nombre;
        int vida;
        string description;
        // Start is called before the first frame update
        void Start()
        {

        }
        public virtual void Setup(string _name, string _descripcion, int _vida)
        {
            nombre = _name;
            description = _descripcion;
            vida = _vida;
            GetComponent<SpriteRenderer>().sprite = icons;

        }
    }
}
