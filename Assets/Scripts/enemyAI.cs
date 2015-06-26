using UnityEngine;
using System.Collections;

/*! Script name: enemyAI.cs
 * Description: enemyAI script is attached to the enemy game object 'labrador'
 * this script receives information from maze pieces regarding possible destinations
 * from that location.  EnemyAI script chooses random destination from possible destinations
 * */

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
	
	void Start ()  //! Start function excuted one time, upon enemy object creation, initializes destination array
	{   destinationArray = new string[4]; 
		//destination = "startTile";
		previousDestination = "NULL";
		nav = GetComponent <NavMeshAgent> ();
		arrayFilled=false;}

	/*!fillArray functions receive information via Unity-specific 'SendMessage' command,
	 * and fill array with possible destinations from current location, 
	 and sets boolean arrayFilled to true*/
	void fillArray0(string fromMazeScript)
	{destinationArray[0] = fromMazeScript;}

	void fillArray1(string fromMazeScript)
	{destinationArray[1] = fromMazeScript;}

	void fillArray2(string fromMazeScript)
	{destinationArray[2] = fromMazeScript;}

	void fillArray3(string fromMazeScript)
	{destinationArray[3] = fromMazeScript;
		arrayFilled=true;}

	/*! OnCollisionEnter() checks if the enemy collides with the player, 
	 * and if so, load the 'deathScreen' scene*/
	void OnCollisionEnter(Collision collision) 
	{
		if (collision.gameObject.name == "Dark_Cat_Prefab")
		{Application.LoadLevel("DeathScreen");} //redirect to death screen
	}

	/*!OnTriggerEnter function is called when the enemy collides with another object.  Performs a check
	 * to see if array of destinations has been filled, and if so, choose a destination, and store previous 
	 * destination*/
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
		}
	}


	/*!OnCollisionExit called when enemy object separated from the objet it collided with, initiating
	 * OnTriggerEnter().  Resets boolean variable arrayFilled to false*/
	void OnCollisionExit(Collision collision)
	{
		arrayFilled=false;
	}
	
	//! Update() sets the destination to that chosen in OnTriggerEnter()
	void Update () {nav.SetDestination(GameObject.Find (destination).transform.position);}
}
