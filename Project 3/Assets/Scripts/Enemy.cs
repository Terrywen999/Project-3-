using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 10;

    public Vector3 direction;

    public GameObject player;
    public GameObject range;

    public Transform playerTrans;

    public  float moveSpeed =5f;

    public Animator explosion;
    
    
    private void Start()
    {
       
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(collision.gameObject);


        }
    }



}
