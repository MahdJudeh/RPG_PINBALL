using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorMovement : MonoBehaviour {
	bool positionLock;
	float distance;
	Vector3 initialPosition;
	// Use this for initialization
	void Start () {
		positionLock = false;
		initialPosition = gameObject.GetComponent<Transform> ().position;
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (gameObject.GetComponent<Transform> ().position, initialPosition);
		Debug.Log (distance);
		if(positionLock == false){
			gameObject.GetComponent<Transform> ().position += new Vector3 (.05f, .05f, 0f);
			if(System.Math.Round(distance, 1) == 8){
				gameObject.GetComponent<Transform> ().localScale = new Vector3 (-2, 2, 1);
				positionLock = true;
			}
		}
		else {
			gameObject.GetComponent<Transform> ().position -= new Vector3 (.05f, .05f, 0f);
			if(System.Math.Round(distance, 1) == 0){
				gameObject.GetComponent<Transform> ().localScale = new Vector3 (2, 2, 1);
				positionLock = false;
			}
		}
	}
}
