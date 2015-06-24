using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {
	
	Transform destinationTransform;
	NavMeshAgent nav;
	public GameObject collidingWith;
	public GameObject destination;
	public GameObject previousDestination;
	string waypointName;
	
	
	void Start ()
	{
		destination = GameObject.Find ("startTile");
		nav = GetComponent <NavMeshAgent> ();
		//	destination = GameObject.Find("wpA"); //hardcode first destination?
		
	}
	
	void OnCollisionEnter(Collision collision) //check if collision is with player
	{
		if (collision.gameObject.name == "Dark_Cat_Prefab")
		{Application.LoadLevel("DeathScreen");} //redirect to death screen
	}
	//receives argument from waypoint upon collision, determining next destination)
	void OnTriggerEnter(Collider collision)
	{

		if (collision.gameObject != collidingWith) {
			collidingWith = collision.gameObject;
			collidingWith.SendMessage ("setPreviousDestination", previousDestination);
		}
		
	}

	void nextDestination (GameObject nextDestination)
	{
		previousDestination = destination;
		destination = nextDestination;
	}
	
	// Update is called once per frame
	void Update () {
		destinationTransform = destination.transform;
		nav.SetDestination(destinationTransform.position);
		
	}
}
