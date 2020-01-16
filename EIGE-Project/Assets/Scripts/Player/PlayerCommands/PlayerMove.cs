﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : PlayerCommand
{
    private bool facingLeft = true;
    public override void run(PlayerManager player)
    {
        //player.rigidbody2D.velocity = new Vector2(player.properties.movementSpeed * Input.GetAxis("Horizontal"), player.rigidbody2D.velocity.y);
        float speed = player.properties.movementSpeed * Input.GetAxis("Horizontal");

        player.transform.Translate(player.transform.right * speed);
        //Animations
        player.GetComponent<Animator>().SetFloat("Speed", Mathf.Abs(speed)*10);
        if (Input.GetAxis("Horizontal") > 0 && facingLeft == false){
            facingLeft = true;
            player.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < 0&& facingLeft == true) {
            facingLeft = false;
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
