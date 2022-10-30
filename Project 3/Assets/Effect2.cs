using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect2 : MonoBehaviour
{
    Transform player;
    public GameObject effectBomb;
    
    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
    private void Update()
    {
        transform.position = player.position;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Instantiate(effectBomb, transform.position, Quaternion.identity);
        }
    }


    
}
