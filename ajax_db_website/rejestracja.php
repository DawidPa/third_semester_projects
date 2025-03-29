<?php

$imie = $_POST['imie'];
$nazwisko = $_POST['nazwisko'];
$email = $_POST['email'];
$haslo = $_POST['haslo'];
$conn = mysqli_connect("localhost","root","","login_db");

if($conn->connect_error){
    die('Connection Failed: ' .$conn->connect_error);
}else{
    $stmt = $conn->prepare("insert into user(imie, nazwisko, email, haslo)
    values(?, ?, ?, ?)");
    $stmt->bind_param("ssss",$imie, $nazwisko, $email, $haslo);
    $stmt->execute();
    header("Location: index.html?error=Blad");
    echo '<script>alert("Rejestracja pomyślna")</script>';
    $stmt->close();
    $conn->close();
    
}


?>
