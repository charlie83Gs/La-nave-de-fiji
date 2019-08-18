using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    private PlayerControls controls;
	private Vector2 move;
    private Vector2 rotate;
    private float speed = 1f;

    public string player;
    

    private void Awake()
    {
        controls = new PlayerControls();

        controls.Player.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => move = Vector2.zero;

        controls.Player.Aim.performed += ctx => rotate = ctx.ReadValue<Vector2>();

        controls.Player.PickUpThrow.performed += ctx => Debug.Log(ctx);
  
    }
   
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 m = new Vector3(move.x * speed, rb.velocity.y, move.y * speed);
        rb.velocity = m;
        Vector3 r = new Vector3(rotate.x, 0, rotate.y);
        transform.rotation = Quaternion.LookRotation(r);
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }
}