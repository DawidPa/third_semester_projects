const imie = document.getElementById('imie')
const nazwisko = document.getElementById('nazwisko')
const email = document.getElementById('email')
const haslo = document.getElementById('haslo')
const haslo2 = document.getElementById('haslo2')
const form = document.getElementById('form')
const error = document.getElementById('error')

/* 
form.addEventListener('submit', (e) => {
    let messages = []

    if (haslo.value.length < 7){
        messages.push('hasło musi mieć więcej niż 6 znaków')
    }

    else if (haslo.value != haslo2.value){
        messages.push('hasła się nie zgadzają')
    }

    if (messages.length > 0) {
        e.preventDefault()
        error.innerText = messages.join(', ')
    }
    
   
})
*/
