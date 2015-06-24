using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {
	
	Transform destinationTransform;
	NavMeshAgent nav;
	public GameObject collidingWith;
	public string destination;
	public string previousDestination;
	public string[] destinationArray;
	bool arrayFilled;

	GameObject destinationObject;
	string temp;
	
	void Start ()
	{
		destinationArray = new string[4];
		destination = "startTile";
		previousDestination = "NULL";
		nav = GetComponent <NavMeshAgent> ();
		arrayFilled=false;
		
	}


	void fillArray0(string fromMazeScript)
	{destinationArray[0] = fromMazeScript;}

	void fillArray1(string fromMazeScript)
	{destinationArray[1] = fromMazeScript;}

	void fillArray2(string fromMazeScript)
	{destinationArray[2] = fromMazeScript;}

	void fillArray3(string fromMazeScript)
	{destinationArray[3] = fromMazeScript;
		arrayFilled=true;}


	void OnCollisionEnter(Collision collision) //check if collision is with player
	{
		if (collision.gameObject.name == "Dark_Cat_Prefab")
		{Application.LoadLevel("DeathScreen");} //redirect to death screen
	}
	//receives argument from waypoint upon collision, determining next destination)
	void OnTriggerEnter(Collider collision)
	{
		collidingWith = collision.gameObject;
		if (arrayFilled==true)
		{
		do 
			{temp = destinationArray[Random.Range (0,4)];}
		while (temp=="NULL" || temp == previousDestination);

		previousDestination = destination;
		destination = temp;
		destinationTransform = destinationObject.transform;
			arrayFilled=false;}

	}


	
	// Update is called once per frame
	void Update () {

		nav.SetDestination(GameObject.Find (destination).transform.position);

		
	}
}
