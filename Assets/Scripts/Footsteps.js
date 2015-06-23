#pragma strict

var AudioFile:AudioClip;

function Start () {

}

function Update () {
	if (Input.GetKeyDown (KeyCode.W))
 	{
     	GetComponent.<AudioSource>().clip = AudioFile;
     	GetComponent.<AudioSource>().Play();
 
 	}
 	if (Input.GetKeyUp (KeyCode.W))
 	{
     	GetComponent.<AudioSource>().clip = AudioFile;
     	GetComponent.<AudioSource>().Stop();
 
 	}
}