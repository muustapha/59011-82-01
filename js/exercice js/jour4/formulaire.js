const telephoneInput = document.getElementById('telephone');
const codePostalInput = document.getElementById('codePostal');
const emailInput = document.getElementById('email');
const motDePasseInput = document.getElementById('motDePasse');

// Valider le numéro de téléphone (format xx-xx-xx-xx-xx)
telephoneInput.addEventListener('input', () => {
    const phoneNumber = telephoneInput.value;
    const phoneNumberPattern = /^\d{2}-\d{2}-\d{2}-\d{2}$/;
    if (!phoneNumberPattern.test(phoneNumber)) {
        telephoneInput.setCustomValidity('Le numéro de téléphone doit être au format xxx-xxx-xxxx.');
    } else {
        telephoneInput.setCustomValidity('');
    }
});

// Valider le code postal (format xxxxx)
codePostalInput.addEventListener('input', () => {
    const postalCode = codePostalInput.value;
    const postalCodePattern = /^\d{5}$/;
    if (!postalCodePattern.test(postalCode)) {
        codePostalInput.setCustomValidity('Le code postal doit contenir cinq chiffres.');
    } else {
        codePostalInput.setCustomValidity('');
    }
});

// Valider l'adresse e-mail
emailInput.addEventListener('input', () => {
    const email = emailInput.value;
    const emailPattern = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    if (!emailPattern.test(email)) {
        emailInput.setCustomValidity('L\'adresse e-mail n\'est pas valide.');
    } else {
        emailInput.setCustomValidity('');
    }
});

// Valider le mot de passe (exigences personnalisées)
motDePasseInput.addEventListener('input', () => {
    const motDePasse = motDePasseInput.value;
    // Ajoutez ici vos propres règles de validation pour le mot de passe
    // Par exemple, vérifier la longueur minimale, la présence de chiffres, etc.
    // Vous pouvez utiliser des expressions régulières ou d'autres méthodes de validation.
    if (motDePasse.length < 8) {
        motDePasseInput.setCustomValidity('Le mot de passe doit contenir au moins 8 caractères.');
    } else {
        motDePasseInput.setCustomValidity('');
    }
});
