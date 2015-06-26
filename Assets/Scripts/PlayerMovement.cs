using UnityEngine;
//using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float speed = 6f;
	Animator anim;                      // Reference to the animator component.
	
	
	void Start () {
		anim = GetComponent <Animator> ();
	}

	
	void Update () {
		transform.Rotate(0,Input.GetAxis("Horizontal")*180*Time.deltaTime,0);
		//		transform.forward;
		ControlPlayer();
	}
	
	
	void ControlPlayer()
	{ 
		float forwardMov = -Input.acceleration.y;
		float sideMov = Input.acceleration.x;

		Vector3 movement = new Vector3(0, 0.0f, forwardMov);
		//if (h != 0 || v != 0) {
		//	transform.rotation = Quaternion.LookRotation (movement);
		//}
		
		transform.Translate (movement * speed * Time.deltaTime, Space.Self);
		
		// Create a boolean that is true if either of the input axes is non-zero.
		bool walking = sideMov != 0f || forwardMov != 0f;
		
		// Tell the animator whether or not the player is walking.
		anim.SetBool ("IsWalking", walking);
		
	}
}
