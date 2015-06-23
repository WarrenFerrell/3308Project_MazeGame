#pragma strict

var AudioFile:AudioClip;

function Start () {

}

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