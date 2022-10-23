using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall1 : Entity
{
    public int wall1Health = 5;
    private Bullet bullet; 
    int damage;
  
    private void Update()
    {
        //damage = bullet.GetComponent<Bullet>().bulletDamage;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Wall1 wall1 = collision.GetComponent<Wall1>();
        if (collision.gameObject.CompareTag("Bullet"))
        {
            wall1Health -= collision.gameObject.GetComponent<Bullet>().bulletDamage;
            //TakeDamage(damage);
            
        }
        if (wall1Health <= 0)
        {
           Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Wall1 wall1 = collision.gameObject.GetComponent<Wall1>();
        if (collision.gameObject.CompareTag("Bullet"))
        {
            wall1Health -= collision.gameObject.GetComponent<Bullet>().bulletDamage;
            //TakeDamage(damage);

        }
        if (wall1Health <= 0)
        {
            Destroy(gameObject);
            AstarPath.active.Scan();
        }
    }
}
