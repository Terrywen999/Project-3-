using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRange : MonoBehaviour
{

    
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("STAY");
            collision.gameObject.GetComponent<Enemy>().EnemyShoot();

        }
    }
}
