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
    public CharacterController player;
    private Vector3 move;
    public float g = 10;
    
    private void Update()
    {
        float x = 0, z = 0;
        if (player.isGrounded)
        {
            x = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");
            var trans = transform;
            move = trans.right * x + trans.forward * z;
            move *= moveSpeed;
            if (Input.GetAxis("Jump") == 1)
            {
                move.y = jumpSpeed;
            }
        }

        move.y = move.y - g * Time.deltaTime;
        
        player.Move( Time.deltaTime * move);
    }
}
