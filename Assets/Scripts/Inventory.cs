using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Inventory : IEnumerable
{
    public Dictionary<Item, int> items;

    public Inventory()
    {
        items = new Dictionary<Item, int>();
    }

    public void AddItem(Item item)
    {
        if (items.ContainsKey(item))
        {
            items[item]++;
        }
        else
        {
            items[item] = 1;
        }
    }

    public IEnumerator GetEnumerator()
    {
        return items.GetEnumerator();
    }

    public Item RemoveItem(Item item)
    {
        if (!items.ContainsKey(item))
        {
            throw new ArgumentException("Item was not found in the inventory");
        }
        items[item]--;
        if (items[item] == 0)
        {
            items.Remove(item);
        }
        return item;
    }

    public override string ToString()
    {
        return items.ToString();
    }
}
