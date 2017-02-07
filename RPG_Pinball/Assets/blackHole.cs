using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class blackHole : MonoBehaviour {
	public GameObject ball;
	private Vector3 initialLocationOfBall;
	// Use this for initialization
	void Start () {
		initialLocationOfBall = ball.GetComponent<Transform> ().position;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") 
		{
			if (GameController.lives != 0) 
			{
				Debug.Log ("did Work");
				GameController.lives--;
				Instantiate (ball, initialLocationOfBall, Quaternion.identity);
				Destroy (other.gameObject);
				Debug.Log ("did Work");
			} else 
			{
				SceneManager.LoadScene (1);
			}

		}
	}
}
