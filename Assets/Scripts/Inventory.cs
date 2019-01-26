using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryGUI;

    private bool isVisible;

    // Start is called before the first frame update
    void Start()
    {
        isVisible = false;
        InventoryGUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldDisplayInventory()) {
            isVisible = !isVisible;
            InventoryGUI.SetActive(isVisible);
        }
    }

    private bool ShouldDisplayInventory()
    {
        return Input.GetKeyUp(KeyCode.E) || 
                (isVisible && Input.GetKeyUp(KeyCode.Escape));
    }
}
