using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(RayPerception3D))]
public class FijiAgent : Agent
{

    public float rotateSpeed = 1;
    public float moveSpeed = 1;
    public bool useVectorObs;
    private Rigidbody agentRB;
    private ResetParameters resetParams;
    public float food =1;
    RayPerception rayPer;
    float[] rayAngles = { 245f, 270f, 295f };
    string[] detectableObjects = { "food", "Player", "wall", "creature" };
    public float visionDistance = 12f;

    private FijiAcademy academy;
    private int stepts = 0;




    public override void InitializeAgent()
    {

        base.InitializeAgent();
        //academy = Object.FindObjectOfType<FijiAcademy>();
        academy = GetComponentInParent<FijiAcademy>();


        //extract componets from game object
        agentRB = GetComponent<Rigidbody>();
        rayPer = GetComponent<RayPerception>();

        //resetParams = academy.resetParameters;
        //SetResetParameters();

        //hunger mechanics
        //IEnumerator getHungryCoroutine = getHungry(0.5f);
        //StartCoroutine(getHungryCoroutine);
        SetReward(0f);


    }

    public override void CollectObservations()
    {
        if (useVectorObs)
        {
            AddVectorObs(rayPer.Perceive(visionDistance, rayAngles, detectableObjects, 0f, 0f));
            AddVectorObs(rayPer.Perceive(visionDistance, rayAngles, detectableObjects, 1.5f, 0f));
        }
        //AddVectorObs(gameObject.transform.rotation.x);
        //AddVectorObs(ball.transform.position - gameObject.transform.position);
        //AddVectorObs(ballRb.velocity);
    }

    public override void AgentAction(float[] vectorAction, string textAction)
    {
        Debug.Log("action");

        float actionRotation = 0;
        if (vectorAction[1] == 1) {
            actionRotation -= rotateSpeed;
        } else if (vectorAction[1] == 2) {
            actionRotation = rotateSpeed;
        }

        //APpLY ROTATION
        Vector3 rotateVector = transform.up * actionRotation;
        agentRB.MoveRotation(Quaternion.Euler(agentRB.rotation.eulerAngles + rotateVector * rotateSpeed));

        float actionMotion = 0;
        if (vectorAction[0] == 1) {
            actionMotion -= moveSpeed;
        } else if (vectorAction[0] == 2) {
            actionMotion = moveSpeed;
        }

        //APPLY MOTION
        Vector3 moveVector = transform.forward * actionMotion;
        //agentRB.AddForce(moveVector*moveSpeed, ForceMode.VelocityChange);
        agentRB.velocity = moveVector * moveSpeed + new Vector3(0, agentRB.velocity.y, 0);

        //Debug.Log(moveVector);

        if (food < 0) {
            SetReward(-1f);
            Done();
        }
        if (food > 4) {
            SetReward(5f);
            Done();
        }

        if (GetCumulativeReward() < -5f) {
            Done();
        }

        /*if (true){
            Done();
            SetReward(-1f);
        }
        else
        {
            SetReward(0.1f);
        }*/
        if (stepts % 5 == 0) {
            food -= moveSpeed / 50;
        }

        //Debug.Log(agentParameters.maxStep);
        AddReward(-1f / 1000);
        stepts++;
    }

    public Vector3 GetRandomSpawnPos()
    {
        bool foundNewSpawnLocation = false;
        Vector3 randomSpawnPos = Vector3.zero;

       float randomPosX = Random.Range(-academy.areaBounds.extents.x * academy.spawnAreaMarginMultiplier,
                                academy.areaBounds.extents.x * academy.spawnAreaMarginMultiplier);

       float randomPosZ = Random.Range(-academy.areaBounds.extents.z * academy.spawnAreaMarginMultiplier,
                                            academy.areaBounds.extents.z * academy.spawnAreaMarginMultiplier);
       randomSpawnPos =  academy.gameObject.transform.position + new Vector3(randomPosX, 1f, randomPosZ);
       /*if (Physics.CheckBox(randomSpawnPos, new Vector3(2.5f, 0.01f, 2.5f)) == false)
       {
            foundNewSpawnLocation = true;
       }*/
        
        return randomSpawnPos;
    }






    /// <summary>
    /// In the editor, if "Reset On Done" is checked then AgentReset() will be 
    /// called automatically anytime we mark done = true in an agent script.
    /// </summary>
    public override void AgentReset()
    {
        base.AgentReset();
        SetReward(0f);
        int rotation = Random.Range(0, 4);
        float rotationAngle = rotation * 90f;
        food = 1;
        
        transform.position = GetRandomSpawnPos();
        Debug.Log("Agent Reset");
        /*agentRB.velocity = Vector3.zero;
        agentRB.angularVelocity = Vector3.zero;*/

    }




    public void feed(float foodConsumed) {
        AddReward(1f);
        food += foodConsumed;
    }
    /*
    //get ungry over time
    private IEnumerator getHungry(float waitTime) {
        while (true) {

            yield return new WaitForSeconds(waitTime);
            food -= moveSpeed / 50;
        }
        

    }*/

}
