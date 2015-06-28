#pragma strict

/*
Function: Start
After 10 seconds of real time the game loads the Main Menu scene
*/

function Start () {
	yield WaitForSeconds(10);
	Application.LoadLevel("MainMenu");
}

