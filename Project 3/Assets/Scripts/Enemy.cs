using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    public int damage = 10;

    public int bulletDamage = 1;

    

    public GameObject player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = collision.collider.GetComponent<Player>();
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("DAMAGE");
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
