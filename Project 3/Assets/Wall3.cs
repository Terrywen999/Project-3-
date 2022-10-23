using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall3 : MonoBehaviour
{
    public int wallHealth;
    public Transform player;
    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }
    private void Update()
    {
        transform.position = player.position ;    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Wall3 wall3 = collision.gameObject.GetComponent<Wall3>();
        if (collision.gameObject.CompareTag("Bullet"))
        {
            wallHealth -= collision.gameObject.GetComponent<Bullet>().bulletDamage;
            Destroy(collision.gameObject.GetComponent<Bullet>());
        }
    }
}
