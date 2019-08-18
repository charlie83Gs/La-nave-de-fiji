using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luminosity.IO;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    private GlobalSettings settings;

    public float speed = 1.5f;
    public PlayerID player;

    private void Awake()
    {
        settings = GlobalSettings.Instance;
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed *= settings.GetSettings().speedMultiplier;
    }

    private void Update()
    {
        float hor = InputManager.GetAxis("HorizontalMove", player);
        float ver = InputManager.GetAxis("VerticalMove", player);
        if (0 != hor  || 0 != ver)
        {
            rb.MovePosition(transform.position + new Vector3(hor, 0, -ver) * speed * Time.deltaTime);
        }

        float aimHor = InputManager.GetAxis("HorizontalAim", player);
        float aimVer = InputManager.GetAxis("VerticalAim", player);
        if(aimVer != 0 || aimHor != 0)
        {
            Vector3 r = new Vector3(aimHor, 0, -aimVer);
            transform.rotation = Quaternion.LookRotation(r, Vector3.up);
        }
    }



}