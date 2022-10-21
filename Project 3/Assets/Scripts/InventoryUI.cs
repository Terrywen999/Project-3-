using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public SlotUI[] slots;
    Inventory inventory;

    void Start()
    {
        //inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        //inventory.itemAdd.AddListener(OnItemAdd);
    }

    void OnItemAdd(int index, int number)
    {
        slots[index].number.text = number.ToString();
    }
}
