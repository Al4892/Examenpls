using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;

public enum Raritys
    {
        Base = 0,
        wood = 1,
        stone = 2,
        iron = 3,
        gold = 4,
        diamond = 5
    }
public class Item : MonoBehaviour
{
   
        public Sprite icons;
        public Raritys Rareza;
        public TextMeshProUGUI descripcion;
    public TextMesh info;
                  
        string nombre;
        int vida;
        string description;
        // Start is called before the first frame update
        void Start()
        {
        
          
            descripcion.text = ""+nombre+""+description;
        }
        public virtual void Setup(string _name, string _descripcion, int _vida,Raritys Rare)
        {
            nombre = _name;
            description = _descripcion;
            vida = _vida;
            Rareza= Rare;
           

        }
    
}
