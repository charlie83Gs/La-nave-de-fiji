using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(RayPerception3D))]
public class CreaturePlayAgent : Agent
{
    public float rotateSpeed = 1;
    public float moveSpeed = 1;
    public bool useVectorObs;
    private Rigidbody agentRB;
    private ResetParameters resetParams;
    public float food = 1;
    RayPerception rayPer;
    float[] rayAngles = { 235,255f, 270f, 285f, 305f};
    string[] detectableObjects = { "food", "Player", "wall", "creature" };
    public float visionDistance = 12f;

    private int stepts = 0;

    public override void InitializeAgent()
    {

        base.InitializeAgent();

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
            AddVectorObs(agentRB.velocity);
            AddVectorObs(rayPer.Perceive(visionDistance, rayAngles, detectableObjects, 0.3f, 0f));
            //AddVectorObs(rayPer.Perceive(visionDistance, rayAngles, detectableObjects, 0.9f, 0f));
        }
        //AddVectorObs(gameObject.transform.rotation.x);
        //AddVectorObs(ball.transform.position - gameObject.transform.position);
        //AddVectorObs(ballRb.velocity);
    }

    public override void AgentAction(float[] vectorAction, string textAction)
    {
       

        float actionRotation = 0;
        if (vectorAction[1] == 1)
        {
            actionRotation -= rotateSpeed;
        }
        else if (vectorAction[1] == 2)
        {
            actionRotation = rotateSpeed;
        }

        //APpLY ROTATION
        Vector3 rotateVector = transform.up * actionRotation;
        agentRB.MoveRotation(Quaternion.Euler(agentRB.rotation.eulerAngles + rotateVector * rotateSpeed));
        Debug.Log(rotateVector);
        float actionMotion = 0;
        if (vectorAction[0] == 1)
        {
            actionMotion -= moveSpeed;
        }
        else if (vectorAction[0] == 2)
        {
            actionMotion = moveSpeed;
        }

        //APPLY MOTION
        Vector3 moveVector = transform.forward * actionMotion;
        agentRB.AddForce(moveVector, ForceMode.Acceleration);
        //Debug.Log(moveVector);

        if (stepts % 5 == 0)
        {
            food -= 0.0003f * moveSpeed ;
        }

        if (food < 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void feed(float foodConsumed)
    {
        AddReward(1f);
        food += foodConsumed;
    }
}
