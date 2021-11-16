using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public string itemName;
    public bool isPickedUp;
    //public Image icon;
 




    //   public Item item;
    // Start is called before the first frame update
    public void Start()
    {
        itemName = this.gameObject.name;
        isPickedUp = false;

    }

    public void Awake()
    {
        if(this.gameObject.activeInHierarchy == false) 
        {
            GameObject[] item = GameObject.FindGameObjectsWithTag("Item");

            if (item.Length > 1)
            {
                Debug.Log(item[1].gameObject.name);
                Destroy(item[1]);
            }

            
        }
        DontDestroyOnLoad(this.gameObject);

    }





}
