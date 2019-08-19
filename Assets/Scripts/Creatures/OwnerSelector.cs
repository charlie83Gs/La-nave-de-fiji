using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnerSelector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor" && !collision.gameObject.GetComponent<AreaInfo>().hasCreature(gameObject))
        {
            collision.gameObject.GetComponent<AreaInfo>().addCreature(gameObject);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "floor")
        {
            collision.gameObject.GetComponent<AreaInfo>().removeCreature(gameObject);
        }
    }
}
