using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]
public class Player : MonoBehaviour
{
    public GameObject TestItem;
    public GameObject TestItem2;
    public Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = new Inventory();
        Item item = TestItem.GetComponent<Item>();
        inventory.AddItem(item);
        inventory.AddItem(item);
        item = TestItem2.GetComponent<Item>();
        inventory.AddItem(item);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Inventory GetInventory()
    {
        return inventory;
    }
}
