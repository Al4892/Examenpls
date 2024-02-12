using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;
using Unity.Properties;
using Unity.VisualScripting;
using UnityEngine.UI;

public enum Raritys
    {
        Normal = 0,
        Comun = 1,
        Raro = 2,
        Epico= 3,
        Especial = 4,
        Legenadrio = 5
    }
public class Item : MonoBehaviour
{
    public List<GameObject> Bag = new List<GameObject>();
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
        
          
           
        }
        public virtual void Setup(string _name, string _descripcion, int _vida,Raritys Rare)
        {
            nombre = _name;
            description = _descripcion;
            vida = _vida;
            Rareza= Rare;
           

        }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Item"))
        {
            for (int i = 0; i < Bag.Count; i++)
            {
                
                    if (Bag[i].tag == "Item")
                    {
                    descripcion.text = "<color=green>Rareza 1</color>" + "\n<color=red>Daño: 45 pts</color>" + "\n<color=purple>Se puede usar para atacar a criaturas</color>";

                    break;

                    }
                                  
                                                      
            }
        }
        if (collision.CompareTag("Item2"))
        {
            for (int i = 0; i < Bag.Count; i++)
            {
                if (Bag[i].tag == "Item2")
                {

                    descripcion.text = "<color=blue>Rareza 3</color>" + "\n<color=red>Curacion: 50 pts</color>"+"\n<color=purple>Cura al jugador, solo tiene un uso</color>";



                    break;

                }
                
            }
        }
        if (collision.CompareTag("Item3"))
        {
            for (int i = 0; i < Bag.Count; i++)
            {
                if (Bag[i].tag == "Item3")
                {
                    descripcion.text = "<color=black>Rareza 5</color>" + "\n<color=red>Usos 1 pts</color>" + "\n<color=purple>Revive al jugador con toda sus propiedades completas</color>";
                    
                    break;

                }
                
            }
        }
        if (collision.CompareTag("Untagged"))
        {
            for (int i = 0; i < Bag.Count; i++)
            {
                if (Bag[i].tag == "Untagged")
                {
                    descripcion.color= Color.white;
                    descripcion.text = "";
                    break;

                }
                
            }
        }
    }
}
    


