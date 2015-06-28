/*!ScoreKeeper added to player character
 * Keeps score of all collectible objects picked up by player, and displays score
 */

using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public static int Score; //!Score variable to increment score
	//public CollectibleObject pickupItem;
	public GUIText scoreText; //!Text from empty game object to display score
	
	void Start() //!Initializes score to zero and calls UpdateScore() to display score
	{
		Score = 0;
		UpdateScore ();

	}

	/*!void OnTriggerEnter (Collider collidingObject)
	 * Checks for the collision object tag and increments scoreb based on the collectible object's tag
	 */

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "CollectObject") { //!Adds 10 upon collision with CollectObject collectible object
			Score += 10;
			UpdateScore();
		}
		if (other.tag == "BigCollect") { //!Adds 50 upon collision with BigCollect collectible object
			Score += 50;
			UpdateScore ();
		}
		if (other.tag == "HugeCollect") { //!Adds 100 upon collision with HugeCollect collectible object
			Score += 100;
			UpdateScore ();
		}
	}

	/*!void UpdateScore()
	 * Updates the scoreText object to print "Score:" and the value of the Score variable
	 */

	void UpdateScore()
	{
		scoreText.text = "Score: " + Score; //!Sends score to GUIText to display on screen
	}
}
