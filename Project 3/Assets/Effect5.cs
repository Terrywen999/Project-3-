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
            collision.gameObject.GetComponent<Enemy>().StartAttracting(transform);
        }

    }

    
}
