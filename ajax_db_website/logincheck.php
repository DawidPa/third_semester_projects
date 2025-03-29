<?php
    $conn = mysqli_connect("localhost","root","","login_db");
    $email = $_POST['email'];
    $haslo = $_POST['haslo'];
    

    $sql = "SELECT * FROM user WHERE email='$email' AND haslo='$haslo'";
    $result = mysqli_query($conn, $sql);
    if(mysqli_num_rows($result)==1)
    {
        echo '<script>alert("Logowanie pomyślne")</script>';
      
        
        exit();
    }
    else 
    {
        echo '<script>alert("Błąd logowania")</script>';
        
       
     
        exit();
       
    }
?>