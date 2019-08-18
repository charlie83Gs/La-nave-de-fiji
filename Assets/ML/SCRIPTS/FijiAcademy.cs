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
    }

    public override void AcademyReset()
    {
    	
    }
   



}
