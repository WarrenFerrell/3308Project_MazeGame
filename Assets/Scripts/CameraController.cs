using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform player;

	public float rotMag;
	private Vector3 offset;
	//private Vector3 deltaPos;
	private Vector3 playerLastPos;




	// Use this for initialization
	void Start () {
		offset = transform.localPosition - player.position; 
	}
	
	// Update is called once per frame
	void LateUpdate () {
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		transform.position = player.localPosition + offset;
		//transform.RotateAround(player.position,player.up, rotMag*moveHorizontal);
		//playerLastPos = player.position;
	}
}
