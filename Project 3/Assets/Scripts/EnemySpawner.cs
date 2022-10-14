using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy1;
    [SerializeField]
    private float enemy1Interval =1.5f;
    void Start()
    {
        StartCoroutine(spawnEnemy(enemy1Interval, enemy1));
    }

   private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5),
            Random.Range(-6f, 6f), 0), Quaternion.identity);

        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
