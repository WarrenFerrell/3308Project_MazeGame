#pragma strict
 
 var theTimer : float = 0.0;
 var theStartTime : float = 120.0;
 var showRemaining : boolean = false;
 var MyFont : Font;
 
 function Start() 
 {
     theTimer = theStartTime;
 }
 
 function Update() 
 {
     theTimer -= Time.deltaTime;
 
     
 
     if ( Input.GetKeyUp(KeyCode.G) )
     {
         Debug.Log("Resetting");
         theTimer = theStartTime;
         showRemaining = false;
     }
 }
 
 function OnGUI() 
 {
     var text : String = String.Format( "{1:00}", parseInt( theTimer / 60.0 ), parseInt( theTimer % 60.0 ) ); 
 
     if (showRemaining)
     {
     	GUI.skin.font = MyFont;
         GUI.Label( Rect( 625, 275, Screen.width - 40, 60), text );
     }
 }
 
 