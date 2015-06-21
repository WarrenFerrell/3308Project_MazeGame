using UnityEngine;
using System.Collections;

public class MazeNavigationArray : MonoBehaviour {
	// Use this for initialization

	public Transform[] destinationList;
	RaycastHit pieceFound;
	private int i;
	void Start () {
		i = 0;
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

	void OnTriggerEnter(Collider collision) {
		++i;
		if (i % 2 == 0) {
			destinationList [0].gameObject.SetActive (false);
			destinationList [1].gameObject.SetActive (false);
			destinationList [2].gameObject.SetActive (false);
			destinationList [3].gameObject.SetActive (false);
		} else {
			destinationList [0].gameObject.SetActive (true);
			destinationList [1].gameObject.SetActive (true);
			destinationList [2].gameObject.SetActive (true);
			destinationList [3].gameObject.SetActive (true);
		}


	}

}
