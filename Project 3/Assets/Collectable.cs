using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemCollection
{
    public GameObject item;
    public int id;
}

public class Collectable : MonoBehaviour
{
    public ItemCollection[] allItems;
    public Transform player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (ItemCollection i in allItems)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                if (i.id == 1)
                {
                    Instantiate(i.item, player.position, Quaternion.identity);
                    Destroy(gameObject);
                }
                if (i.id == 2)
                {
                    Instantiate(i.item, player.position, Quaternion.identity);
                    Destroy(gameObject);
                }
            }
        }

    }
}
