using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditorInternal;
using UnityEditor;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using Unity.VisualScripting;

public class Inventarios : MonoBehaviour
{


    public List<GameObject> Bag = new List<GameObject>();
    public GameObject[] inv;
    public bool Activarinv;
    public GameObject selector;
    public int id;
    public string item_activo;
    public List<Image> Equipo = new List<Image>();
    public int id_equipo;
    public int fasesinv;

    public GameObject Opciones;
    public Image[] Seleccion;
    public Sprite[] Selection_Sprite;
    public int Id_Selected;
   
   
    public void navegar()
    {
        switch (fasesinv)
        {
            case 0:
                selector.SetActive(true);//
                Opciones.SetActive(false);//

                inv[1].SetActive(false); 
                if(Input.GetKeyDown(KeyCode.A)&& id_equipo>0) 
                {
                    id_equipo--;
                
                
                } 
                if(Input.GetKeyDown(KeyCode.D)&& id_equipo< Equipo.Count-1) 
                {
                    id_equipo++;
                
                
                }
                selector.transform.position = Equipo[id_equipo].transform.position;
                if (Input.GetKeyDown(KeyCode.F) && Activarinv)
                {
                    fasesinv = 1;
                }

            break;
               case 1:
                selector.SetActive(true);//
                Opciones.SetActive(false);//
                if(Input.GetKeyDown(KeyCode.F)&& Bag[id].GetComponent<Image>().enabled==true)//
                {
                    fasesinv = 2;

                }
                inv[1].SetActive(true);
                if (Input.GetKeyDown(KeyCode.D) && id < Bag.Count - 1)
                {
                    id++;
                }
                if (Input.GetKeyDown(KeyCode.A) && id > 0)
                {
                    id--;
                }
                if (Input.GetKeyDown(KeyCode.W) && id > 3)
                {
                    id -= 4;
                }
                if (Input.GetKeyDown(KeyCode.S) && id < 8)
                {
                    id += 4;
                }
                selector.transform.position = Bag[id].transform.position;
                if(Input.GetKeyDown(KeyCode.G)&& Activarinv) 
                {
                    fasesinv = 0;
                
                }
               break;
                case 2:
                if (Input.GetKeyDown(KeyCode.G))
                {
                    fasesinv = 1;
                }
                Opciones.SetActive (true);
                Opciones.transform.position= Bag[id].transform.position;
                selector.SetActive (false);
                if (Input.GetKeyDown(KeyCode.W)&&Id_Selected>0)
                {
                    Id_Selected--;
                }
                if (Input.GetKeyDown(KeyCode.S) && Id_Selected < Seleccion.Length - 1)
                {
                    Id_Selected++;
                }
                switch (Id_Selected)
                {
                    case 0:
                        Seleccion[0].sprite = Selection_Sprite[1];
                        Seleccion[1].sprite = Selection_Sprite[0];
                        if (Input.GetKeyDown(KeyCode.F))
                        {
                            if (Equipo[id_equipo].GetComponent<Image>().enabled == false)
                            {
                                Equipo[id_equipo].GetComponent<Image>().sprite = Bag[id].GetComponent<Image>().sprite;
                                Equipo[id_equipo].GetComponent<Image>().enabled = true;
                                if (Bag[id].CompareTag("Item")==true)
                                {
                                 Equipo[id_equipo].AddComponent<Objeto1>().enabled = true;
                                    Equipo[id_equipo].tag = "Item";
                                    Bag[id].tag = "Untagged";

                                    Destroy(Bag[id].GetComponent<Objeto1>());

                                } 
                                if (Bag[id].CompareTag("Item2")==true)
                                {
                                 Equipo[id_equipo].AddComponent<Objeto2>().enabled = true;
                                    Equipo[id_equipo].tag = "Item2";
                                    Bag[id].tag = "Untagged";

                                    Destroy(Bag[id].GetComponent<Objeto2>());

                                } 
                                if (Bag[id].CompareTag("Item3")==true)
                                {
                                 Equipo[id_equipo].AddComponent<Objeto3>().enabled = true;
                                    Equipo[id_equipo].tag = "Item3";
                                    Bag[id].tag = "Untagged";
                                    Destroy(Bag[id].GetComponent<Objeto3>());

                                }
                                
                                Bag[id].GetComponent<Image>().sprite = null;
                                Bag[id].GetComponent<Image>().enabled = false;
                                
                            }
                            else
                            {
                                Sprite obj = Bag[id].GetComponent<Image>().sprite;
                                Bag[id].GetComponent<Image>().sprite = Equipo[id_equipo].GetComponent<Image>().sprite;
                                Equipo[id_equipo].GetComponent<Image>().sprite = obj;

                                string tempTag = Bag[id].tag;
                                Bag[id].tag = Equipo[id_equipo].tag;
                                Equipo[id_equipo].tag = tempTag;


                                if (Bag[id].tag == "Item")
                                {
                                    if (Equipo[id_equipo].GetComponent<Objeto1>() == null)
                                    {
                                        Bag[id].GetComponent<Objeto1>().enabled = Equipo[id_equipo].AddComponent<Objeto1>();
                                                                                                                   
                                     Equipo[id_equipo].tag = "Item";
                                      
                                    }
                                    Destroy(Equipo[id_equipo].GetComponent<Objeto2>());
                                    Destroy(Equipo[id_equipo].GetComponent<Objeto3>());
                                    

                                } 
                                if (Bag[id].tag == "Item2")
                                {
                                    
                                    if (Equipo[id_equipo].GetComponent<Objeto2>()==null)
                                    {
                                        
                                        
                                       Bag[id].GetComponent<Objeto2>().enabled = Equipo[id_equipo].AddComponent<Objeto2>();
                                    Equipo[id_equipo].tag = "Item2";
                                        
                                    }
                                    Destroy(Equipo[id_equipo].GetComponent<Objeto1>());
                                    Destroy(Equipo[id_equipo].GetComponent<Objeto3>());


                                } 
                                if (Bag[id].tag == "Item3")
                                {
                                    if (Equipo[id_equipo].GetComponent<Objeto3>() == null)
                                    {
                                        Bag[id].GetComponent<Objeto3>().enabled = Equipo[id_equipo].AddComponent<Objeto3>();
                                     Equipo[id_equipo].tag= "Item3";
                                        
                                    }
                                    Destroy(Equipo[id_equipo].GetComponent<Objeto1>());
                                    Destroy(Equipo[id_equipo].GetComponent<Objeto2>());

                                }

                            }
                            fasesinv = 0;

                        }
                    break;
                        case 1:
                        Seleccion[0].sprite = Selection_Sprite[0];
                        Seleccion[1].sprite = Selection_Sprite[1];
                        if (Input.GetKeyDown(KeyCode.F))
                        {
                            Bag[id].GetComponent<Image>().sprite = null;
                            Bag[id].GetComponent<Image>().enabled = false;
                            if (Bag[id].GetComponent<Objeto1>() != null) 
                            {
                                Destroy(Bag[id].GetComponent<Objeto1>());
                                Bag[id].tag= "Untagged";
                             
                            
                            } 
                            if (Bag[id].GetComponent<Objeto2>() != null) 
                            {
                                Destroy(Bag[id].GetComponent<Objeto2>());
                                Bag[id].tag = "Untagged";

                            } 
                            if (Bag[id].GetComponent<Objeto3>() != null) 
                            {
                                Destroy(Bag[id].GetComponent<Objeto3>());
                                Bag[id].tag = "Untagged";


                            }
                            fasesinv = 1;

                        } 
                        
                        break;
                }
                break;
        }




       
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {

            for (int i = 0; i < Bag.Count; i++)
            {
                if (Bag[i].GetComponent<Image>().enabled == false)
                {

                    Bag[i].GetComponent<Image>().enabled = true;
                    Bag[i].GetComponent<Image>().sprite = collision.GetComponent<SpriteRenderer>().sprite;
                    Bag[i].AddComponent<Objeto1>().enabled = true;
                    Bag[i].tag = "Item";
                    collision.gameObject.SetActive(false);
                    


                    break;
                }

            }

        }
        if (collision.CompareTag("Item2"))
        {

            for (int i = 0; i < Bag.Count; i++)
            {
                if (Bag[i].GetComponent<Image>().enabled == false)
                {

                    Bag[i].GetComponent<Image>().enabled = true;
                    Bag[i].GetComponent<Image>().sprite = collision.GetComponent<SpriteRenderer>().sprite;
                    Bag[i].AddComponent<Objeto2>().enabled = true;
                    Bag[i].tag= "Item2";
                    collision.gameObject.SetActive(false);


                    break;
                }

            }

        }
        if (collision.CompareTag("Item3"))
        {

            for (int i = 0; i < Bag.Count; i++)
            {
                if (Bag[i].GetComponent<Image>().enabled == false)
                {

                    Bag[i].GetComponent<Image>().enabled = true;
                    Bag[i].GetComponent<Image>().sprite = collision.GetComponent<SpriteRenderer>().sprite;
                    Bag[i].AddComponent<Objeto3>().enabled=true;
                    Bag[i].tag = "Item3";
                    collision.gameObject.SetActive(false);

                    

                    break;
                }

            }

        }

    }
   

    private void Update()
    {
        navegar();
        if (Activarinv)
        {
            inv[0].SetActive(true);
        }
        else
        {
            fasesinv= 0;
            inv[0].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Activarinv = !Activarinv;
        }
        Vector3 posicionRaton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionRaton.z = 0f;  

        
        transform.position = posicionRaton;
    }
   
}
