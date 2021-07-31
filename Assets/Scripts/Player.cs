﻿using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour {

    void HandleMovement()
    {
        if(isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertial = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal * 0.1f, moveVertial * 0.1f, 0);
            transform.position += movement;
        }
    }

    void Update()
    {
        HandleMovement();
    }
}