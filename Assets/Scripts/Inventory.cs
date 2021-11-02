using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    public bool poison;
    public bool letter;
    public bool cupcake;
    public bool skates;
    // Start is called before the first frame update
    public Inventory(bool poi, bool cup, bool let, bool ska)
    {
        poison = poi;
        cupcake = cup;
        letter = let;
        skates = ska;
    }

    public Inventory()
    {
        poison = false;
        cupcake = false;
        letter = false;
        skates = false;
    }
}
