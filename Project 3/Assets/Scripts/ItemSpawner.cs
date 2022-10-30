using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] item;
    [SerializeField]
    private float itemInterval = 1.5f;
        void Start()
    {
        StartCoroutine(spawnItem(itemInterval, item));
    }

    private IEnumerator spawnItem(float interval, GameObject[] item)
    {
        yield return new WaitForSeconds(interval);
        GameObject newItem = Instantiate(item[Random.Range(0, item.Length)], new Vector3(Random.Range(-5f, 5),
            Random.Range(-6f, 6f), 0), Quaternion.identity);

        StartCoroutine(spawnItem(interval, item));
    }
}
