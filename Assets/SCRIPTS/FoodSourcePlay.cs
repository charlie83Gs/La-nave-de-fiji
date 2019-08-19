using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSourcePlay : MonoBehaviour
{
    public float nutritionalValue = 1;
    public string cosumerTag = "creature";

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Food");
        //Debug.Log("food is being tocuhed!! " + collision.gameObject.tag + "/" + cosumerTag +(collision.gameObject.tag==co));
        if (collision.gameObject.tag == cosumerTag)
        {
            GameObject creature = collision.gameObject;
            CreaturePlayAgent agent = creature.GetComponent<CreaturePlayAgent>();
            agent.feed(nutritionalValue);
            nutritionalValue = 0;
            Destroy(gameObject);
        }

    }
}
