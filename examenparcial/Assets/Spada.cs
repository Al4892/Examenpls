using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Rarity
{
    Base=0,
    wood=1,
    stone=2,
        iron=3,
        gold=4,
        diamond=5
}
public enum Enchantment
{
    None=0,
    Fire=1,
    Throw=2
}

public class SpadaBase : MonoBehaviour
{
    public Sprite icon;
    public Rarity rarity;
    public Enchantment enchantment;
    public int daño;
    public int dureza;
    public bool ataque;
    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = icon;
    }
    public virtual void Setup(string _name, int _damage, int _durability)
    {
        name = _name;
        daño = _damage;
        dureza = _durability;
        GetComponent<SpriteRenderer>().sprite= icon;

    }
    public virtual int getattack() { return 0; }

}

