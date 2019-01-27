using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    private const int GutterSize = 1;

    public GameObject InventoryGUI;
    public GameObject PlayerObject;
    public GameObject ItemsGUI;
    public GameObject ItemSlot;

    private bool isVisible;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        isVisible = false;
        InventoryGUI.SetActive(isVisible);
        player = PlayerObject.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldDisplayInventory()) {
            isVisible = !isVisible;
            InventoryGUI.SetActive(isVisible);
            PopulateItemSlots();
        }
    }

    void PopulateItemSlots()
    {
        foreach (KeyValuePair<Item, int> itemPair in player.GetInventory())
        {
            GameObject itemSlot = Instantiate(
                ItemSlot,
                ItemsGUI.transform
            );
            Image itemImage = itemSlot.GetComponent<Image>();
            itemImage.sprite = itemPair.Key.Image;

            Text itemCount = itemSlot.transform.GetChild(0).GetComponent<Text>();
            itemCount.text = itemPair.Value.ToString();
        }
    }

    private bool ShouldDisplayInventory()
    {
        return Input.GetKeyUp(KeyCode.E) || 
                (isVisible && Input.GetKeyUp(KeyCode.Escape));
    }
}
