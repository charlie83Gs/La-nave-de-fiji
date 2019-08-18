using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

[RequireComponent(typeof(Rigidbody)) ]
[RequireComponent(typeof(CapsuleCollider)) ]
public class FijiAgent : Agent
{

	public float rotateSpeed = 1;
	public float moveSpeed = 1;
	private Rigidbody agentRB;
	private ResetParameters resetParams;

	public override void InitializeAgent()
    {
        agentRB = GetComponent<Rigidbody>();
        var academy = Object.FindObjectOfType<Academy>() as Academy;
        //resetParams = academy.resetParameters;
        //SetResetParameters();
    }

	public override void CollectObservations()
    {
        AddVectorObs(gameObject.transform.position);
        //AddVectorObs(gameObject.transform.rotation.x);
        //AddVectorObs(ball.transform.position - gameObject.transform.position);
        //AddVectorObs(ballRb.velocity);
    }
	
	 public override void AgentAction(float[] vectorAction, string textAction)
    {

		float actionRotation = 0;
		if(vectorAction[1] == 1){
			actionRotation -= rotateSpeed;
		}else if(vectorAction[1] == 2){
			actionRotation = rotateSpeed;
		}

		//APpLY ROTATION
		Vector3 rotateVector = transform.up * actionRotation;
		agentRB.MoveRotation(Quaternion.Euler(agentRB.rotation.eulerAngles + rotateVector*rotateSpeed));
		
		float actionMotion = 0;
		if(vectorAction[0] == 1){
            actionMotion -= moveSpeed;
		}else if(vectorAction[0] == 2){
            actionMotion = moveSpeed;
		}

        //APPLY MOTION
        Vector3 moveVector = transform.forward * actionMotion;
        agentRB.AddForce(moveVector*moveSpeed, ForceMode.VelocityChange);

        if (GetCumulativeReward() < -5.0f) {
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
    }

}
