using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool openDoorState = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (openDoorState)
        {
            if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.F))
            {
                openDoorState = false;
                Debug.Log("open the door!");
            }
        }
        else
        {
            if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.F))
            {
                openDoorState = true;
                Debug.Log("close the door!");
            }       
        }
    }
}
