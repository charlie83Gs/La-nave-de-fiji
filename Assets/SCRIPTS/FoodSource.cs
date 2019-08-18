using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FoodSource : MonoBehaviour
{
    public float nutritionalValue = 1;
    public string cosumerTag = "creature";

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Food");
        //Debug.Log("food is being tocuhed!! " + collision.gameObject.tag + "/" + cosumerTag +(collision.gameObject.tag==co));
        if (collision.gameObject.tag == cosumerTag) {
            GameObject creature = collision.gameObject;
            FijiAgent agent = creature.GetComponent<FijiAgent>();
            agent.feed(nutritionalValue);
            nutritionalValue = 0;
            Destroy(gameObject);
        }

    }

}
