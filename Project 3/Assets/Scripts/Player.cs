using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{

    private Item currSelect;

    private void Start()
    {
        currSelect = Item.None;
    }


    public override void Die()
    {
        gameObject.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            currSelect = Item.WallNormal;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            currSelect = Item.WallNormal;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            currSelect = Item.WallNormal;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            currSelect = Item.WallNormal;
        }

        if (Input.GetMouseButton(0) && currSelect != Item.None)
        {
            //matched item
            //Instantiate()

            //Inventory remove
        }
    }
}
