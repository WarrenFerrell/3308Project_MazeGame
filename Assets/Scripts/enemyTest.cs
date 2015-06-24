using UnityEngine;
using System.Collections;

public class enemyTest : MonoBehaviour {
	Transform waypoint;
	//PlayerHealth playerHealth;
	//EnemyHealth enemyHealth;
	NavMeshAgent nav;
	string collidingWith;
	string goingToString;
	string comingFrom;
	int goingToInt;
	int counter;
	string[] patrolRoute = new string[6] {"wpA","wpB","wpC","wpD","wpC","wpB"};

	void Start ()
	{

		nav = GetComponent <NavMeshAgent> ();
		goingToString="wpA";

	}


	void OnCollisionEnter(Collision collision)
	{
		collidingWith=collision.gameObject.name;
		if (collidingWith == goingToString)
		{
			counter++;
			if (counter>5)
			{counter=0;}
			goingToString = patrolRoute[counter];
		}

	}
	// Update is called once per frame
	void Update () {
		waypoint = GameObject.Find(goingToString).transform;
		nav.SetDestination(waypoint.position);
	
	}
}
