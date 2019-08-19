using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureSpawner : MonoBehaviour
{
    public float spawnAreaMarginMultiplier = 1;
    private Bounds areaBounds;
    public GameObject creaturePrefab;
    public int creaturesToSpawn = 5;
    private void Start()
    {
        areaBounds = GetComponent<BoxCollider>().bounds;
    }

    private void FixedUpdate()
    {
        if (creaturesToSpawn > 0)
        {
            creaturesToSpawn--;
            Instantiate(creaturePrefab, GetRandomSpawnPos(), Quaternion.identity);
        }
    }
    private Vector3 GetRandomSpawnPos()
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
