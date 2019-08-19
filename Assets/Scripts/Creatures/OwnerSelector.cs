using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnerSelector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "floor" && !other.gameObject.GetComponent<AreaInfo>().hasCreature(gameObject))
        {
            other.gameObject.GetComponent<AreaInfo>().addCreature(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "floor")
        {
            other.gameObject.GetComponent<AreaInfo>().removeCreature(gameObject);
        }
    }

}
