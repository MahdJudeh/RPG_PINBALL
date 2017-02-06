using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour {
	JointMotor motorA;
	JointMotor motorB;
	JointMotor motorReturnA;
	JointMotor motorReturnB;
	// Use this for initialization
	void Start () 
	{
		motorA = gameObject.GetComponent<HingeJoint> ().motor;
		motorB = gameObject.GetComponent<HingeJoint> ().motor;
		motorReturnA = gameObject.GetComponent<HingeJoint> ().motor;
		motorReturnB = gameObject.GetComponent<HingeJoint> ().motor;
		motorA.targetVelocity = -3000;
		motorB.targetVelocity = 3000;
		motorReturnB.targetVelocity = -3000;
		motorReturnA.targetVelocity = 3000;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (gameObject.tag == "PaddleL") {
			
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
				gameObject.GetComponent<HingeJoint> ().motor = motorA;
			}
			else{
				gameObject.GetComponent<HingeJoint> ().motor = motorReturnA;
			}
		}
		if (gameObject.tag == "PaddleR") {
			if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
				gameObject.GetComponent<HingeJoint> ().motor = motorB;
			}
			else{
				gameObject.GetComponent<HingeJoint> ().motor = motorReturnB;
			}
		}
	}
}
