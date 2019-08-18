using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class FijiAcademy : Academy
{
    public float agentRunSpeed;
	public float agentRotationSpeed;
	public float spawnAreaMarginMultiplier = 1;
    public Material goalScoredMaterial;
    public Material failMaterial;
	public float gravityMultiplier;
    public GameObject foodPrefab;
    public float foodGeneartion;
    public float food = 0;
    public Bounds areaBounds;

    public override void InitializeAcademy()
    {
        base.InitializeAcademy();
        areaBounds = GetComponent<BoxCollider>().bounds;

        //IEnumerator getHungryCoroutine = generateFood(0.1f);
        //StartCoroutine(getHungryCoroutine);
    }

    public override void AcademyReset()
    {
    	
    }
    
    private void FixedUpdate()
    {
        
        food += foodGeneartion;
        //Debug.Log(food);

        if (food > 1)
        {
            Instantiate(foodPrefab, GetRandomSpawnPos(), Quaternion.identity);
            food -= 1;
        }
    }
    

    private IEnumerator generateFood(float waitTime) {
        while (true)
        {
            food += foodGeneartion* waitTime;

            if (food > 1)
            {
                Instantiate(foodPrefab, GetRandomSpawnPos(), Quaternion.identity);
                food -= 1;
            }
            yield return new WaitForSeconds(waitTime);
            
        }
    }

    public Vector3 GetRandomSpawnPos()
    {
        bool foundNewSpawnLocation = false;
        Vector3 randomSpawnPos = Vector3.zero;

        float randomPosX = Random.Range(-areaBounds.extents.x *spawnAreaMarginMultiplier,
                                 areaBounds.extents.x * spawnAreaMarginMultiplier);

        float randomPosZ = Random.Range(-areaBounds.extents.z * spawnAreaMarginMultiplier,
                                             areaBounds.extents.z * spawnAreaMarginMultiplier);

        //Debug.Log(-areaBounds.extents.x * spawnAreaMarginMultiplier + "---"+randomPosZ);
        randomSpawnPos = transform.position + new Vector3(randomPosX, 1f, randomPosZ);
        /*if (Physics.CheckBox(randomSpawnPos, new Vector3(2.5f, 0.01f, 2.5f)) == false)
        {
             foundNewSpawnLocation = true;
        }*/

        return randomSpawnPos;
    }


}
