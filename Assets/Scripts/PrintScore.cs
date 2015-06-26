using UnityEngine;
using System.Collections;

public class PrintScore : MonoBehaviour {

	public GUIText scoreText;

	// Use this for initialization
	void Start () {
		scoreText.text = "" + ScoreKeeper.Score;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
