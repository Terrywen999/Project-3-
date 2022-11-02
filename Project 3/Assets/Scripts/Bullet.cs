using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Entity
{
    private Rigidbody2D rb;
    Vector3 lastVelocity;

    public float speed;

    int hitTimes;

    public int bulletDamage = 1;    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       

        //bullet hit wall and rebound.
        if (collision.gameObject.CompareTag("Rebound"))
        {
            //var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0f);
            bulletDamage += 3;
        }
        //bullet hit wall and rebound.END

        
    }

}
