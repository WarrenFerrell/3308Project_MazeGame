using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public static int Score;
	public CollectibleObject pickupItem;
	public GUIText scoreText;
	
	void Start()
	{
		Score = 0;
		UpdateScore ();

	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "CollectObject") {
			Score += 10;
			UpdateScore();
		}
		if (other.tag == "BigCollect") {
			Score += 50;
			UpdateScore ();
		}
		if (other.tag == "HugeCollect") {
			Score += 100;
			UpdateScore ();
		}
	}

	void UpdateScore()
	{
		scoreText.text = "Score: " + Score;
	}
}
