<?php 
        $db = mysql_connect('[where server is hosted]', '[user with access to server]', '[user password]') or die('Could not connect: ' . mysql_error()); 
        mysql_select_db('[database name]') or die('Could not select database');
 
        // Strings must be escaped to prevent SQL injection attack. 
        $name = mysql_real_escape_string($_GET['name'], $db); 
        $score = mysql_real_escape_string($_GET['score'], $db); 
        $hash = $_GET['hash']; 
 
        $secretKey="[secret key]"; # Value must match the value stored in the client script (ScoreController)

        $real_hash = md5($name . $score . $secretKey); 
        if($real_hash == $hash) { 
            // Send variables for the MySQL database class. 
            $query = "insert into scores values (NULL, '$name', '$score');"; 
            $result = mysql_query($query) or die('Query failed: ' . mysql_error()); 
        } 
?>
