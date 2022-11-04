using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy1;
    [SerializeField]
    private float enemy1Interval =1.5f;
    [SerializeField]
    private GameObject enemyWave;
    [SerializeField]
    private float Wave1Interva = 5f;
    [SerializeField]
    private GameObject enemyWave2;


    float time;
    TimeCount timeCount;
    void Start()
    {
        StartCoroutine(spawnEnemy(enemy1Interval, enemy1));

        StartCoroutine(spawnEnemy(Random.Range(0f,10f), enemyWave));
        StartCoroutine(spawnEnemy(Random.Range(0f, 10f), enemyWave2));
    }

   

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5),
            Random.Range(-6f, 6f), 0), Quaternion.identity);

        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
