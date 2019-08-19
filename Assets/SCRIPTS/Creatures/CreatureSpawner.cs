using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureSpawner : MonoBehaviour
{
    public float spawnAreaMarginMultiplier = 1;
    private Bounds areaBounds;
    public GameObject[] creatures;

    public int creaturesToSpawn = 5;
    public int timeBetweenSpanws = 5;
    private float timer;
    private AreaInfo info;

    private void Start()
    {
        areaBounds = GetComponent<BoxCollider>().bounds;
        timer = timeBetweenSpanws;
        info = GetComponent<AreaInfo>();
    }

    private void FixedUpdate()
    {
        if (creaturesToSpawn > 0)
        {
            creaturesToSpawn--;
            int r = Random.Range(0, creatures.Length);
            Instantiate(creatures[r], GetRandomSpawnPos(), Quaternion.identity);
        }

    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0 && info.creatures.Capacity > 0)
        {
            int r = Random.Range(0, info.creatures.Capacity);
            GameObject newCreature = Instantiate(info.creatures[r],GetRandomSpawnPos(), Quaternion.identity);
            newCreature.GetComponent<CreaturePlayAgent>().food = 1;
            timer = timeBetweenSpanws;
            info.hasSwpawned = true;
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
