using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    public float currentTime = 0f;

    [SerializeField]
    public Text countTime;

    private void Update()
    {
        currentTime += 1 * Time.deltaTime;
        countTime.text = currentTime.ToString("0");

    }
}
