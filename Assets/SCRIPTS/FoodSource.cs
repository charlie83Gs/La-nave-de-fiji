﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FoodSource : MonoBehaviour
{
    public float nutritionalValue = 1;
    public string cosumerTag = "creature";
    public float maxSteps = 2000;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == cosumerTag) {
            GameObject creature = collision.gameObject;
            FijiAgent agent = creature.GetComponent<FijiAgent>();
            agent.feed(nutritionalValue);
            nutritionalValue = 0;
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        maxSteps--;
        if (maxSteps < 0) {
            Destroy(this.gameObject);
        }
    }
}
