using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour {
	JointMotor2D motorA;
	JointMotor2D motorB;
	JointMotor2D motorReturnA;
	JointMotor2D motorReturnB;
	// Use this for initialization
	void Start () 
	{
		motorA = gameObject.GetComponent<HingeJoint2D> ().motor;
		motorB = gameObject.GetComponent<HingeJoint2D> ().motor;
		motorReturnA = gameObject.GetComponent<HingeJoint2D> ().motor;
		motorReturnB = gameObject.GetComponent<HingeJoint2D> ().motor;
		motorA.motorSpeed = -1500;
		motorB.motorSpeed = 1500;
		motorReturnB.motorSpeed = -1000;
		motorReturnA.motorSpeed = 1000;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (gameObject.tag == "PaddleL") {
			
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
				gameObject.GetComponent<HingeJoint2D> ().motor = motorA;
			}
			else{
				gameObject.GetComponent<HingeJoint2D> ().motor = motorReturnA;
			}
		}
		if (gameObject.tag == "PaddleR") {
			if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
				gameObject.GetComponent<HingeJoint2D> ().motor = motorB;
			}
			else{
				gameObject.GetComponent<HingeJoint2D> ().motor = motorReturnB;
			}
		}
	}
}
