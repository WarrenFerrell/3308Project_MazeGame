#pragma strict

/*
Variable: AudioClip
Variable to store the audio file for the footsteps
*/
var AudioFile:AudioClip;

function Start () {

}

/*
Function: Update
Plays footstep audio file if the player character is moving forwards or backwards
*/
function Update () {
	if ((Input.GetKeyDown (KeyCode.W))||(Input.GetKeyDown (KeyCode.S)))
 	{
     	GetComponent.<AudioSource>().clip = AudioFile;
     	GetComponent.<AudioSource>().Play();
 
 	}
 	if ((Input.GetKeyUp (KeyCode.W))||(Input.GetKeyUp (KeyCode.S)))
 	{
     	GetComponent.<AudioSource>().clip = AudioFile;
     	GetComponent.<AudioSource>().Stop();
 
 	}
}