

<!DOCTYPE html>
<html lang="en">
<head>
    
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Form</title>
    <link rel="stylesheet" href="css2.css">
    <script defer src="script.js"></script>
</head>
<body>
   
    <div id = "content">
       
    <form id="form" action="rejestracja.php" method="post">
        
        <div class="form_input-container">
        <label id="name">Imie</label>
        <input id="imie" name="imie"type="text" required/>
        </div>

        <div class="form_input-container">
        <label id="surname">Nazwisko</label>
        <input id="nazwisko" name="nazwisko"type="nazwisko" required/>
        </div>

        <div class="form_input-container">
            <label id="pass">Hasło</label>
            <input id="haslo" name="haslo"type="password" required/>
        </div>

        <div class="form_input-container">
            <label id="pass2">Powtórz hasło</label>
            <input id="haslo2" name="haslo2"type="password" required/>
        </div>  

        <div class="form_input-container">
        <label id="mail">Email</label>
        <input id="email" name="email" type="email" required/>
        </div>
       <br>
    
        
        <div id="buttons">
        <input class="klik" type="submit" value="submit" />  
        <input class="klik" type="submit" onclick="location.href='index.html';" value="Przejdź do menu" />  
         </div>
         <div id="error"></div>
    </form>
    <br>
  
    </div>
    
    
    <div id="footer">
        <h4>Strona autorstwa: Dawid Parobczy</h4>
    </div>
</body>
</html>


