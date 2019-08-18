using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punisher : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "creature") {
            collision.gameObject.GetComponent<FijiAgent>().punish();
        }
    }

}
