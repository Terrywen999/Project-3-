using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    public int damage = 10;

    public Vector3 direction;

    public GameObject player;
    public GameObject range;

    public Transform playerTrans;

    private Rigidbody2D rb;

    private Vector2 movement;
    public  float moveSpeed =5f;

    //enemy shoot 
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;
    private float nextTimeToFire = .5f;
    public float fireRate;
    //private float nextSpawnTime = 1f;

    //public GameObject enemyPrefab;
    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        playerTrans = player?.GetComponent<Transform>();
        range = GameObject.FindWithTag("Range");
    }

    private void Update()
    {
        if(playerTrans == null)
        {
            return;
        }
        direction = playerTrans.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        //moveCharacter(movement);
        //EnemyShoot();
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
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
    public void EnemyShoot()
    {
        if (Time.time >= nextTimeToFire)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
            Destroy(bullet, 5f);

            nextTimeToFire = Time.time + 1f / fireRate;
        }
    }


}
