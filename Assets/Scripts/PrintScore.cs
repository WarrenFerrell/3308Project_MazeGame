using UnityEngine;
using System.Collections;

/*
Class: PrintScore
Prints the user's score to the screen
*/
public class PrintScore : MonoBehaviour {
	/*
	Variable: scoreText
	The variable that holds the GUIText which is the Unity game 		object where the users score is stored and shown on screen
	*/
	public GUIText scoreText;

	// Use this for initialization
	/*
	Function: Start
	Collects the the user's score from the global variable 		Scorekeeper.Score and assigns it the GUI text on the death 		scene.
	*/
	void Start () {
		scoreText.text = "" + ScoreKeeper.Score;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width-Screen.width/4, Screen.height/2, 100, 100), "" + ScoreKeeper.Score);
	}

}
