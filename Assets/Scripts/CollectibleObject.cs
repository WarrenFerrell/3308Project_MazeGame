using UnityEngine;
using System.Collections;

public class CollectibleObject : MonoBehaviour {

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			Destroy(this.gameObject);
		}
	}
}
