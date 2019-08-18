using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luminosity.IO;

public class InputTest : MonoBehaviour
{
    private void Update()
    {
        Debug.Log("VerticalMove: " + InputManager.GetAxis("VerticalMove"));
        Debug.Log("HorizontalMove: " + InputManager.GetAxis("HorizontalMove"));
    }
}
