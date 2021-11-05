using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpenController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public GameObject door;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // TODO 显示按E开门的提示
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Player Push the E");
                bool x = door.GetComponent<Animator>().GetBool("open");
                x = !x;
                door.GetComponent<Animator>().SetBool("open", x);
            }
            
        }    
    }
}
