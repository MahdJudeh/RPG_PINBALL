using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public Text sText;
	public Text lText;
	public GameObject ball;
	public static int lives;
	public static int score;
	Vector3 initialLocationOfBall;
	// Use this for initialization
	void Start () 
	{
		score = 0;
		lives = 3;
		sText.text = "SCORE: " + score;
		lText.text = "LIVES: " + lives;
		initialLocationOfBall = ball.GetComponent<Transform> ().position;
	}
	
	// Update is called once per frame
	void Update()
	{
		lText.text = "LIVES: " + lives;
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") 
		{
			if (lives != 0) 
			{
				Debug.Log ("did Work");
				lives--;
				lText.text = "LIVES: " + lives;
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
