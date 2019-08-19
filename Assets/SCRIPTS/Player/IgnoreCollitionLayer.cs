using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollitionLayer : MonoBehaviour
{
    public int layerNumber = 8;
    public int layerNumber2 = 9;
    void Start()
    {
        GetComponent<Rigidbody>();
        //Ignore the collisions between layer 0 (default) and layer 8 (custom layer you set in Inspector window)
        Physics.IgnoreLayerCollision(layerNumber, layerNumber2);
    }

}
