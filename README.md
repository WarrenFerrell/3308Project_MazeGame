# Maze Game
MazeGame is a maze crawling game for Android and windows created in Unity.
In the game the player takes control of a dark cat navigating through a maze picking up boxes. The player must avoid randomly patroling dogs and find all the pickups to win the game or claim a new high score.
# 
#Repo Organization
The various files needed for each requirements phase of the project are located in the main project directory.
The "Assets","Library", "ProjectSettings", and "DatabaseScripts" folders contain all the unity files and scripts used by our project
The "Script_Documentation" folder contains the documentation on the scripts used by our game.
The 'executables' folder contains executable files for OS X and Windows, as well as all folders and files necessary for program execution.
#
# Running the Game in Unity development mode
Download Unity3D, clone the repository, then open the project in Unity. Click "Play" to run the game as is
#
#Running the Game through Windows or OS X executable
Download the folder 'executables' and simply double click on the relevant executable file for your operating system.
#
#Project Script Documentation
The project documentation files are located in the "Script_Documentation" folder which is located inside the main project directory.
Instructions on how to view the html documentation are included in a separate README file located inside the "Script_Documentation" folder.
#



# Initialization
Run create_score_database.sql to add Highscore Leaderboard to MySQL server, then add PHP scripts to retrieve and display data from database
#



#
#Credits
Character models and animations from Mixamo.com  
Database scripts and score controller from http://wiki.unity3d.com/index.php?title=Server_Side_Highscores  
#

# To-Do
Establish global leaderboard URL address  
Link game with leaderboard  
Add different levels  
Add levels of difficulty

