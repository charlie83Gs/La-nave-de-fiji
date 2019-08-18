using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableCreature : MonoBehaviour
{
    public bool isPicked;

    public void pickup()
    {
        if(!isPicked)
        {
            isPicked = true;
        }
    }

    public void place()
    {
        isPicked = false;
    }
}
