using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect4Shoot : MonoBehaviour
{
    float moveSpeed = 7f;

    Rigidbody2D rb;

    GameObject enemy;
    Vector2 moveDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enemy = GameObject.FindWithTag("Enemy");
        moveDirection = (enemy.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
