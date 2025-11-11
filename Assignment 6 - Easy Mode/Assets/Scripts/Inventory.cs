using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    [Serializefield] private InventoryItem item;
    public List<InventoryItem> inventory;

    // Start is called before the first frame update
    void Start()
    {
        item = new InventoryItem();
        inventory = new List<InventoryItem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
