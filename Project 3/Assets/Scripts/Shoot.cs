using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce;


    int bulletMax =2;
    int bulletAmount;
    public int fillTime;

    public Text bulletAmountText;

    bool filling;

   
    private void Start()
    {
        bulletAmount = bulletMax;
    }
    private void Update()
    {
        //showing the number of bullet
        bulletAmountText.text = bulletAmount.ToString();
        
       
        if (Input.GetButtonDown("Fire1"))
        {
            PlayerShoot();
        }
    }

    private void FixedUpdate()
    {
        addBullet();
    }

    void PlayerShoot()
    {
        if(bulletAmount > 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            bulletAmount--;
                //Destroy(bullet,  5f);
        }

    }
    void addBullet()
    {
        if(bulletAmount < bulletMax && filling == false)
        {
            StartCoroutine(fillBullet());
            filling = true;
        }
        
    }

    IEnumerator fillBullet()
    {
        yield return new WaitForSeconds(fillTime);
        bulletAmount++;
        filling = false;
    }
}
