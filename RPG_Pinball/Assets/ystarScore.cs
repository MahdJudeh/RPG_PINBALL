using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ystarScore : MonoBehaviour {

	public Text sText;
	// Use this for initialization

	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player") {
			GameController.score += 5;
			sText.text = "SCORE: " + GameController.score;
			Debug.Log ("Ystar");
		}
	}
}
