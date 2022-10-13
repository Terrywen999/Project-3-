using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    public int damage = 10;


    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("DAMAGE");
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
