using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    float currentTime = 0f;

    [SerializeField]
    Text countTime;

    private void Update()
    {
        currentTime += 1 * Time.deltaTime;
        countTime.text = currentTime.ToString("0");

    }
}
