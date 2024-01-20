using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    private int _count;
    public Text counterText;
    public AudioSource sound;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("CoinArea");
        if (other.gameObject.CompareTag("Coin"))
        {
            _count++;
            counterText.text = _count.ToString();
            sound.Play();
            
            Destroy(other.gameObject);
            Debug.Log(_count);
        }
    }
}
