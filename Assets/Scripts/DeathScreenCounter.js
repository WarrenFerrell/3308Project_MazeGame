#pragma strict
 
/*
Variable: theTimer
Holds the current time
*/
 var theTimer : float = 0.0;
/*
Variable: theStartTime
Holds the time that the timer begins at
*/
 var theStartTime : float = 120.0;
 var showRemaining : boolean = false;
 var MyFont : Font;

/*
Function: Start
Begins the timer countdown
*/ 
 function Start() 
 {
     theTimer = theStartTime;
 }
 
/*
Function: Update
Updates the timer so that it counts down in real time 
*/
 function Update() 
 {
     theTimer -= Time.deltaTime;
 
 }
/*
Function: OnGui
Creates the GUI object that will hold and display the timer as it counts down
*/
 function OnGUI() 
 {
     var text : String = String.Format( "{1:00}", parseInt( theTimer / 60.0 ), parseInt( theTimer % 60.0 ) ); 
 
     if (showRemaining)
     {
     	GUI.skin.font = MyFont;
         GUI.Label( Rect( 690, 290, Screen.width - 40, 60), text );
     }
 }
 
 
