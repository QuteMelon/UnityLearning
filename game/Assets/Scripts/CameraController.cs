using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// CameraController: 玩家第一人称视角相机随鼠标进行移动
/// </summary>
public class CameraController : MonoBehaviour
{
    public float mouseSpeed = 10;
    private float _xMove;
    public Transform player;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        var x = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        var y = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;
        _xMove -= y;
        _xMove = Mathf.Clamp(_xMove, -90, 90);
        this.transform.localRotation = Quaternion.Euler(_xMove, 0 , 0);      
        player.Rotate(Vector3.up * x);
    }
}