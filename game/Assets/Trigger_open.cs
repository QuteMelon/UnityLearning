using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_open : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(Time.time + "进入该触发器的对象是" + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(Time.time + "离开该触发器的对象是" + other.gameObject.name);
    }
}
