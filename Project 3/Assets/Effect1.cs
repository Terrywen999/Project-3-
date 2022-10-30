using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect1 : MonoBehaviour
{


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Debug.Log("KillPlayer");
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(DestroyEffect());       
        }
    }

    IEnumerator DestroyEffect()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
