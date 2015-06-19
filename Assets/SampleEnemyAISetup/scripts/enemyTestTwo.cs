using UnityEngine;
using System.Collections;

public class enemyTestTwo : MonoBehaviour {
	Transform nextWaypoint;
	//PlayerHealth playerHealth;
	//EnemyHealth enemyHealth;
	NavMeshAgent nav;
	string collidingWith;
	public string goingToString;
	GameObject destination;
	public GameObject destination2;
	string waypointName;
	string comingFrom;


	void Start ()
	{
		
		nav = GetComponent <NavMeshAgent> ();
		destination2 = GameObject.Find("wpA");
		
	}

	void OnCollisionEnter(Collision collision)
	{
		collidingWith = collision.gameObject.name;
		if (collidingWith == "Dark_Cat")
		
			{Application.LoadLevel("MainMenu");}
	}
	//receives argument from waypoint upon collision, determining next destination)

	void nextDestination (GameObject destination)
	{
		destination2 = destination;
	}

	// Update is called once per frame
	void Update () {
		nextWaypoint = destination2.transform;
		nav.SetDestination(nextWaypoint.position);
		
	}
}
