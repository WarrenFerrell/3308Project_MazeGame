/* 
  Class: ScoreController 
  The ScoreController is used to send the player's score to the server and display highscores from the leaderbaord
 */


using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour
{
	private string secretKey = "mySecretKey"; //! SecretKey established to communicate with server
	public string addScoreURL = ; //!addScoreURL variable holds the address of the addscore script
	public string highscoreURL = ; //!highscoreURL variable holds the address of the leaderboard

	/*
	 Function: Start
	 Runs once to get scores and send them to the server
	 */
/*
	void Start()
	{
		StartCoroutine(GetScores());
	}
	
	/*
	 Function: PostScores 
	 Runs Md5Sum script to create hash value from user name, score and secret key
	 Posts score to leaderboard using addscoreURL variable
	 */


	IEnumerator PostScores(string name, int score)
	{
		//This connects to a server side php script that will add the name and score to a MySQL DB.
		// Supply it with a string representing the players name and the players score.
		string hash = MD5Test.Md5Sum(name + score + secretKey);
		
		string post_url = addScoreURL + "name=" + WWW.EscapeURL(name) + "&score=" + score + "&hash=" + hash;
		
		// Post the URL to the site and create a download object to get the result.
		WWW hs_post = new WWW(post_url);
		yield return hs_post; // Wait until the download is done
		
		if (hs_post.error != null)
		{
			print("There was an error posting the high score: " + hs_post.error);
		}
	}
	
	/*
	 Function: GetScores
	 Retrieves scores from leaderboard for display to the player
	 */
	 
	
	IEnumerator GetScores()
	{
		gameObject.guiText.text = "Loading Scores";
		WWW hs_get = new WWW(highscoreURL);
		yield return hs_get;
		
		if (hs_get.error != null)
		{
			print("There was an error getting the high score: " + hs_get.error);
		}
		else
		{
			gameObject.guiText.text = hs_get.text; // this is a GUIText that will display the scores in game.
		}
	}
	
}
