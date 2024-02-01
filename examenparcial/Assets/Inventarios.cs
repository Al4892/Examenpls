using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditorInternal;
using UnityEditor;


public class Inventarios : MonoBehaviour
{
    
    
    public List<GameObject> Bag = new List<GameObject>();
    public GameObject inv;
    public bool Activarinv;
    public GameObject selector;
    public int id;
    public string item_activo;
    //[Header("Objeto activo")]
    //[SerializeField]
    public void navegar()
    {
        if (Input.GetKeyDown(KeyCode.D) && id < Bag.Count - 1)
        {
            id++;
        }
        if (Input.GetKeyDown(KeyCode.A) && id > 0)
        {
            id--;
        }
        if (Input.GetKeyDown(KeyCode.W) && id >3)
        {
            id-=4;
        }
        if (Input.GetKeyDown(KeyCode.S) && id <8)
        {
            id += 4;
        }
        selector.transform.position = Bag[id].transform.position;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
         /*   
            for(int i = 0; i < Bag.Count; i++)
            {
                if (Bag[i].gameObject.GetComponent<imageprite>().enabled == false)
                {

                 Bag[i].GetComponent<Image>().enabled = true;
                 Bag[i].GetComponent<ima>.sprite = collision.GetComponent<SpriteRenderer>().sprite;
                    break;
                }
            }
            */
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        navegar();
        if (Activarinv)
        {
            inv.SetActive(true);
        }
        else
        {
            inv.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Activarinv = !Activarinv;
        }
    }
}
