using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{

    PlayerControls controls;
	Vector2 move;

    private void Awake()
    {
        controls = new PlayerControls();
        controls.PlayerOne.Move.performed += ctx => {
            move = ctx.ReadValue<Vector2>();
            Debug.Log(ctx);
        };
        controls.PlayerOne.Move.canceled += ctx => move = Vector2.zero;
    }

    private void Update()
    {
        Vector3 m = new Vector3(move.x, 0, move.y);
        transform.Translate(m, Space.World);
    }

    private void OnEnable()
    {
        controls.PlayerOne.Enable();
    }

    private void OnDisable()
    {
        controls.PlayerOne.Disable();
    }
}