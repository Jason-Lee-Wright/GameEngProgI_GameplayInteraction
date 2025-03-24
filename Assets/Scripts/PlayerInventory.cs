using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public TextMeshProUGUI Inventory; // this will simulate an inventory for now.

    [SerializeField]
    private int GemCount = 0;

    private void Start()
    {
        ResetInventory();
        UpdateInventory();
    }

    public void CollectItem(string Item)
    {
        if (Item == "Gem")
        {
            GemCount++;
            Debug.Log(GemCount);
            UpdateInventory();
        }
    }

    void UpdateInventory()
    {
        Debug.Log("UpdateIn");
        Inventory.text = $"Inventory\nGems: {GemCount}";
        Debug.Log(Inventory.text);
    }

    private void ResetInventory()
    {
        GemCount = 0;
    }
}
