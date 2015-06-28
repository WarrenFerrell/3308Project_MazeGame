/*
  Class: MazeNavigationArray
  Creates an array of possible destinations from each array and 
  sends those destinations to each player that reaches the inner trigger of the maze piece
 */
 
  /*
  Authors: Warren Ferrell, Donovan Guelde
  
 */

using UnityEngine;
using System.Collections;

public class MazeNavigationArray : MonoBehaviour {
	// Use this for initialization
	
	public string[] destinationList;
	public string previousDestination;
	string previousDestinationFromAI;
	RaycastHit pieceFound;
	public string destination;
	public string collidingWith;
	
	/*
	  Function: Start
	  Initializes the array for each enemy path node and fills the array with all possible adjacent destinations
	 */
	void Start () {
		int terrainLayerMask = 1 << 8 | 1 << 9; ///ignore all objects not in Terran or Maze Layer
		destinationList = new string[4];
		if (Physics.Raycast(transform.position + 0.25F * Vector3.up, Vector3.forward, out pieceFound, 15, terrainLayerMask)==true && pieceFound.collider.gameObject.layer==8)
			destinationList[0] = pieceFound.collider.gameObject.name;
		else destinationList[0] = "NULL";
		if (Physics.Raycast(transform.position + 0.25F * Vector3.up, Vector3.right,out pieceFound, 15, terrainLayerMask)==true && pieceFound.collider.gameObject.layer==8)
			destinationList[1] = pieceFound.collider.gameObject.name;
		else destinationList[1] = "NULL";
		if (Physics.Raycast(transform.position + 0.25F * Vector3.up, Vector3.back,out pieceFound, 15, terrainLayerMask)==true && pieceFound.collider.gameObject.layer==8)
			destinationList[2] = pieceFound.collider.gameObject.name;
		else destinationList[2] = "NULL";
		if (Physics.Raycast(transform.position + 0.25F * Vector3.up, Vector3.left,out pieceFound, 15, terrainLayerMask)==true && pieceFound.collider.gameObject.layer==8)
			destinationList[3] = pieceFound.collider.gameObject.name;
		else destinationList[3] = "NULL";
	}	
	
	/*
	 Function: OnTriggerEnter
	 On collision with the enemy dog each path node will send an array containing all possible destinations from that node to the enemy ai
	  */

	void OnTriggerEnter(Collider collision)
	{	

		{
			collision.SendMessage("fillArray0",destinationList[0], SendMessageOptions.DontRequireReceiver);
			collision.SendMessage("fillArray1",destinationList[1], SendMessageOptions.DontRequireReceiver);
			collision.SendMessage("fillArray2",destinationList[2], SendMessageOptions.DontRequireReceiver);
			collision.SendMessage("fillArray3",destinationList[3], SendMessageOptions.DontRequireReceiver);
		
			
			
		}
	}
	

}
