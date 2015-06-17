using UnityEngine;
//using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float speed = 6f;
	Animator anim;                      // Reference to the animator component.
	
	
	void Start () {
		anim = GetComponent <Animator> ();
	}
	
	void Update () {
		transform.Rotate(0,Input.GetAxis("Horizontal")*60*Time.deltaTime,0);
		//		transform.forward;
		ControlPlayer();
	}
	
	
	void ControlPlayer()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		
		Vector3 movement = new Vector3(0, 0.0f, v);
		//if (h != 0 || v != 0) {
		//	transform.rotation = Quaternion.LookRotation (movement);
		//}
		
		transform.Translate (movement * speed * Time.deltaTime, Space.Self);
		
		// Create a boolean that is true if either of the input axes is non-zero.
		bool walking = h != 0f || v != 0f;
		
		// Tell the animator whether or not the player is walking.
		anim.SetBool ("IsWalking", walking);
		
	}
	
	
	
}
