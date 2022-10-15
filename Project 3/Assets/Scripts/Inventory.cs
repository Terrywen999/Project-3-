using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum Item
{
    WallNormal,
    WallEnhance,
    Wallxx,
    Wally,
    

    //always last
    None
}

public class Inventory : MonoBehaviour
{
    public bool[] isFull;

    public int[] items;

    public UnityEvent<int, int> itemAdd;


    private void Start()
    {
        items = new int[Enum.GetNames(typeof(Item)).Length];
    }

    public void AddItem(Item item)
    {
        items[(int)item]++;
        itemAdd.Invoke((int)item, items[(int)item]);
    }
}
