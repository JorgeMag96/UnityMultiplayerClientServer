using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : NetworkBehaviour {

    public float moveSpeed = 10f;
    public Rigidbody rb;

    private float _xInput;
    private float _zInput;

    public override void OnStartLocalPlayer() {
        Camera.main.GetComponent<CameraFollow>().playerTransform = transform; //Fix camera on "me" 
        rb = GetComponent<Rigidbody>();
    }

    private void HandleMovement() {
        rb.AddForce(new Vector3(_xInput, 0f, _zInput) * moveSpeed);
    }
    
    private void Update() {
        if (!isLocalPlayer) return;

        ProcessInputs();
    }

    private void FixedUpdate() {
        if (!isLocalPlayer) return;

        HandleMovement();
    }

    private void ProcessInputs() {
        _xInput = Input.GetAxisRaw("Horizontal");
        _zInput = Input.GetAxisRaw("Vertical");
    }
}