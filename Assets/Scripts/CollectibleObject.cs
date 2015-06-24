using UnityEngine;
using System.Collections;

public class CollectibleObject : MonoBehaviour {

	public ScoreKeeper myScoreKeeper;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "CollectObject") {
			myScoreKeeper.Score += 10;
			Destroy(other.gameObject);
		}
	}
}