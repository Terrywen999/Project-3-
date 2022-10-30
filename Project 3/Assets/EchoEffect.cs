using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffect : MonoBehaviour
{
    public float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public GameObject echo;

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(timeBtwSpawns <= 0)
        {
            //spawn echo game object
            Instantiate(echo, transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
