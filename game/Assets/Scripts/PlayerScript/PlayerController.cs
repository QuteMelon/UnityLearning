using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// PlayerController.cs 控制角色运动
/// </summary>


public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10;
    public CharacterController player;
    
    
    private void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        
        var trans = transform;
        var move = trans.right * x + trans.forward * z;
        player.Move(moveSpeed * Time.deltaTime * move);
    }
}
