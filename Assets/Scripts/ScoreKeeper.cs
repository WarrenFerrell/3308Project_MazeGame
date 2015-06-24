using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public static int Score;
	
	void Awake()
	{
		Score = 0;
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(0, 0, 100, 25), "Score: " + Score);
	}
}
