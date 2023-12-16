using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private int count;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            count++;
            Destroy(other.gameObject);
            Debug.Log(count);
        }
    }
}
