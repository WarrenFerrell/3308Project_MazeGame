/*
  Class: CollectibleObject
  script attached to all collectible objects
  Triggers destruction of game object upon contact with the player
 */
using UnityEngine;
using System.Collections;

public class CollectibleObject : MonoBehaviour {

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*
	  Function: OnTriggerEnter
	  Destroys object if player collides with collectible object
	 */

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			Destroy(this.gameObject);
		}
	}
}
