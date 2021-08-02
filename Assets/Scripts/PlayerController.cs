using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : NetworkBehaviour {

    public override void OnStartLocalPlayer()
    {
        Camera.main.GetComponent<CameraFollow>().target=transform; //Fix camera on "me" 
    }

    void HandleMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal * 0.1f, 0,  moveVertical * 0.1f);
        transform.position += movement;
    }

    void Update()
    {
        if (!isLocalPlayer) return;

        HandleMovement();
    }
}