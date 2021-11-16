using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public List<Item> ItemList;

    public string iconName;
    public Image iconSka;
    public Image iconHam;
    public Image iconLet;


    public void Start()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {

            GetItem(other.GetComponent<Item>());
            other.gameObject.SetActive(false);
            iconName = "Img" + other.gameObject.name;
            if(iconName == "ImgSka")
            {
                iconSka.enabled = true;
            }
            else if(iconName == "ImgHam")
            {
                iconHam.enabled = true;
            }
            else if (iconName == "ImgLet")
            {
                iconLet.enabled = true;
            }

        }




        if (other.gameObject.CompareTag("Ham"))
        {
            Debug.Log("About to drop");


            DropItem(other.gameObject);
            iconHam.enabled = false;
            
        }


        if (other.gameObject.CompareTag("Ska"))
        {

            DropItem(other.gameObject);
            iconSka.enabled = false;


        }
    }



    public void GetItem(Item item)
    {
      ItemList.Add(item);
      item.isPickedUp = true;
     // item.icon.enabled = true;
        
    }

    public void DropItem(GameObject other)
    {
        for(int i = 0; i < ItemList.Count; i++)
        {
            if (ItemList[i].itemName == other.gameObject.tag && ItemList[i].isPickedUp == true)
            {
                ItemList[i].isPickedUp = false;
            }
        }
        
        
      //  item.icon.enabled = false;

    }




}
