using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript2 : MonoBehaviour {

	Rigidbody2D rb;
	// Use this for initialization
	void Start () 
	{
		rb = gameObject.GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () 
	{
		if (gameObject.tag == "PaddleL") {

			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
				rb.AddTorque (2.0f);
				Debug.Log ("hi");
			}
			else {
				rb.AddTorque (-2.0f);
			}
		}
		if (gameObject.tag == "PaddleR") {
			
			if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
				if (gameObject.transform.rotation.z < 60) {
					rb.AddTorque (2.0f);
					Debug.Log ("hi");
				}
		
				else if(gameObject.transform.rotation.z >= 0) {
					rb.AddTorque (-2.0f);
				}
			}
		}
	}
}
