using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpringControll : MonoBehaviour {

	private Vector3 timeLock;
	private Vector3 initialScale;
	private Vector3 initialForce;
	private int timeMultiplier;
	private bool lockS;
	private bool contact;
	public GameObject ball;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		timeLock = gameObject.GetComponent<Transform> ().localScale - new Vector3 (0f, .5f, 0f);
		initialForce = new Vector3 (0f, 0f, 0f);
		lockS = false;
		contact = false;
		rb = ball.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float distance = Vector3.Distance (gameObject.GetComponent<Transform> ().localScale, timeLock);
		if (Input.GetKey (KeyCode.Space)) {
			
			if (distance > 0f && lockS == false)
			{
				gameObject.GetComponent<Transform> ().localScale -= new Vector3 (0, .01f, 0f);
				initialForce += new Vector3 (0, 40f, 0f);
				if (System.Math.Round(distance, 2) == 0)
				{
					lockS = true;
				}
			}
		}
		else if (distance < .5f)
		{
			gameObject.GetComponent<Transform> ().localScale += new Vector3 (0, .02f, 0f);
			if (System.Math.Round(distance, 1) == .5f)
			{
				
				lockS = false;

				if (contact == true) {
					rb.AddForce (initialForce);
					initialForce = new Vector3 (0f, 0f, 0f);
				}
			}
		}

	}
	void OnTriggerStay2D(Collider2D other){
		Debug.Log (contact);
		if (other.tag == "Player") {
			contact = true;
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player") {
			contact = false;
		}
	}
}
