using UnityEngine;
using System.Collections;

public class MazeNavigationArray : MonoBehaviour {
	// Use this for initialization

	public Transform[] destinationList;
	RaycastHit pieceFound;

	void Start () {
		int terrainLayerMask = 1 << 8; //ignore all objects not in Terran Layer
		destinationList = new Transform[4];
		if (Physics.Raycast(transform.position + 0.25F * Vector3.up, Vector3.forward, out pieceFound, 15, terrainLayerMask)==true)
			destinationList[0] = pieceFound.transform;
		if (Physics.Raycast(transform.position + 0.25F * Vector3.up, Vector3.right,out pieceFound, 15, terrainLayerMask)==true)
			destinationList[1] = pieceFound.transform;
		if (Physics.Raycast(transform.position + 0.25F * Vector3.up, Vector3.back,out pieceFound, 15, terrainLayerMask)==true)
			destinationList[2] = pieceFound.transform;
		if (Physics.Raycast(transform.position + 0.25F * Vector3.up, Vector3.left,out pieceFound, 15, terrainLayerMask)==true)
			destinationList[3] = pieceFound.transform;
	}	


}
