using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public TextMeshProUGUI Inventory; // this will simulate an inventory for now.

    private int GemCount = 0;

    private void Start()
    {
        UpdateInventory();
    }

    public void CollectItem(string Item)
    {
        if (Item == "Gem")
        {
            GemCount++;

        }
    }

    void UpdateInventory()
    {
        Inventory.text = $"Inventory\nGems: {GemCount}\n";
    }
}
