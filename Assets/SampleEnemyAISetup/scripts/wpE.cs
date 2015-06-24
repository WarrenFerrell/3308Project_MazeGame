using UnityEngine;
using System.Collections;

public class wpE : MonoBehaviour {

	string collidingWithName;
	string collidedWithLastTime;
	string[] possibleDestinations = {"wpB","wpC","wpD","wpA"};
	GameObject collidingWith;
	public string destination;
	GameObject prevDestination;



	void previousDestination(GameObject previousDestination)
	{
		prevDestination = previousDestination;
	}
	
	void OnTriggerEnter(Collider collision)
	{
		if (gameObject == prevDestination)
		{
		collidingWith = collision.gameObject;
		collidingWithName = collidingWith.name;

		do
		{int index = Random.Range (0,4);
			destination = possibleDestinations[index];}
		while (destination=="NULL");
		collidingWith.SendMessage("nextDestination",GameObject.Find (destination));
		}
	}




}
