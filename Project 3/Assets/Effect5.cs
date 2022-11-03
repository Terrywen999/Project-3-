using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect5 : MonoBehaviour
{

    public GameObject effect5bomb;
    Rigidbody2D rb;
    Vector2 movement;
    public float moveSpeed = 5f;
    GameObject enemy;

    private void Start()
    {
        StartCoroutine(WaitTheBomb());
        rb = GameObject.FindWithTag("Enemy").GetComponent<Rigidbody2D>();
        enemy = GameObject.FindWithTag("Enemy");
    }

    private void Update()
    {
        Vector3 direction = transform.position - enemy.transform.position;
        float angle = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

    }
    private void FixedUpdate()
    {
        AttractEnemy(movement);
    }
    IEnumerator WaitTheBomb()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
        Instantiate(effect5bomb, transform.position, Quaternion.identity);
        StartCoroutine(DestroyEffect());
    }

    IEnumerator DestroyEffect()
    {
        yield return new WaitForSeconds(3f);
        Destroy(effect5bomb);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.transform.position = gameObject.transform.position;
        }

    }

    void AttractEnemy(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
