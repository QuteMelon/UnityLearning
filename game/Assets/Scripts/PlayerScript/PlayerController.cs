using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// PlayerController.cs 控制角色运动
/// </summary>


public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float jumpSpeed = 5;
    private int jumpTimes = 3; // 跳跃次数
    public CharacterController player;
    private Vector3 move;
    public float g = 10;

    private void start()
    {
        player = GetComponent<CharacterController>();
    }

    private void Fire()
    {
        
    }
    private void jump()
    {
        if (player.isGrounded)
        {
            jumpTimes = 3;
        }
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log(jumpTimes);
            if (jumpTimes > 0)
            {
                move.y = jumpSpeed;
                jumpTimes--;
            }
        }
        move.y = move.y - g * Time.deltaTime;
        player.Move( Time.deltaTime * move);
    }
    private void Run()
    {
        float x = 0, z = 0;
        if (player.isGrounded)
        {
            jumpTimes = 3;
            x = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");
            var trans = transform;
            move = trans.right * x + trans.forward * z;
            move *= moveSpeed;
        }
        player.Move( Time.deltaTime * move);
    }
    
    private void Update()
    {
        jump();
        Run();
    }
}
