using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject openedDoor;
    public GameObject closedDoor;

    private bool isOpened = false;
    private bool isPlayerNear = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
            Debug.Log("Enter door open area");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
        }
    }

    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            isOpened = !isOpened;
            Debug.Log("Door status: " + isOpened);

            if (isOpened)
            {
                openedDoor.SetActive(true);
                closedDoor.SetActive(false);
            }
            /*else
            {
                openedDoor.SetActive(false);
                closedDoor.SetActive(true);
            }*/
        }
    }
}