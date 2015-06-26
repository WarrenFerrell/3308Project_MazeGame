var isQuit=false;
var AudioFile:AudioClip;

/*
Function: OnMouseEnter
Plays audio file and changes text color to red if the user's mouse button clicks down
*/
function OnMouseEnter(){
	//Play Music
	GetComponent.<AudioSource>().clip = AudioFile;
	GetComponent.<AudioSource>().Play();
	//change text color
	GetComponent.<Renderer>().material.color=Color.red;
}

/*
Function: OnMouseExit
Changes text color to blue if the user's mouse moves over a button
*/
function OnMouseExit(){
	//change text color
	GetComponent.<Renderer>().material.color=Color.blue;
}

/*
Function: OnMouseUp
Starts or Quits the game when the user's mouse button clicks up
*/
function OnMouseUp(){
	//is this quit
	if (isQuit==true) {
	//quit the game
		Application.Quit();
	}
	else {
	//load level
		Application.LoadLevel("StaticMaze");
	}
}
/*
Function: Update
Quits the game if "Escape" key is pressed
*/
function Update(){
//quit game if escape key is pressed
	if (Input.GetKey(KeyCode.Escape))
		{ Application.Quit();
	}	
}