﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{



    public float spawnAreaMarginMultiplier = 1;
    public GameObject foodPrefab;
    public float foodGeneartion;
    public float food = 0;
    public Bounds areaBounds;

    private void Start()
    {
        areaBounds = GetComponent<BoxCollider>().bounds;
    }

    private void FixedUpdate()
    {
        food += foodGeneartion;

        if (food > 1)
        {
            Instantiate(foodPrefab, GetRandomSpawnPos(), Quaternion.identity);
            food -= 1;
        }
    }

    public Vector3 GetRandomSpawnPos()
    {
        bool foundNewSpawnLocation = false;
        Vector3 randomSpawnPos = Vector3.zero;

        float randomPosX = Random.Range(-areaBounds.extents.x * spawnAreaMarginMultiplier,
                                 areaBounds.extents.x * spawnAreaMarginMultiplier);

        float randomPosZ = Random.Range(-areaBounds.extents.z * spawnAreaMarginMultiplier,
                                             areaBounds.extents.z * spawnAreaMarginMultiplier);
        randomSpawnPos = transform.position + new Vector3(randomPosX, 1f, randomPosZ);
        return randomSpawnPos;
    }

}
