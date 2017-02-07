using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoonScore : MonoBehaviour {
	public Text sText;
	// Use this for initialization
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player") {
			GameController.score += 20;
			sText.text = "SCORE: " + GameController.score;
			Debug.Log ("MOON");
		}
	}
}
