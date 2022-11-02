using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect4 : MonoBehaviour
{
    Transform player;
    Transform enemy;
    // for bulletShoot
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    float nextFire;
    float fireRate;
    public Transform FirePoint;

    float number = 0.5f;
    Rigidbody2D rb;
    private void Start()
    {
        enemy = GameObject.FindWithTag("Enemy").GetComponent<Transform>();
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        //StartCoroutine(DestroyEffect());
        fireRate = 0.5f;
        nextFire = Time.time;

        rb = this.GetComponent<Rigidbody2D>();
       
    }

    private void Update()
    {
        gameObject.transform.position = new Vector2(player.position.x-number, player.position.y);
        
        
        //transform.rotation = Quaternion.Euler(0, 0, rotation);
        //StartCoroutine(Shooting());
        CheckIfTimeToFire();
    }

    IEnumerator Shooting()
    {
        yield return new WaitForSeconds(nextFire);

        if (Time.time > nextFire)
        {
            Instantiate(bulletPrefab, FirePoint.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }

        //GameObject bullet = Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        //Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //rb.AddForce(FirePoint.up * bulletSpeed, ForceMode2D.Impulse);
    }
    
    IEnumerator DestroyEffect()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bulletPrefab, FirePoint.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }

}
