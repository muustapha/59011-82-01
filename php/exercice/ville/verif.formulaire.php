<!DOCTYPE html>
<html>
<head>
    <title>Formulaire</title> 
    <link rel="stylesheet" href="formulaire.css">
</head>
<body>
    <h2>Formulaire d'inscription</h2>
    <form action="formulaire" method="post">
        <label for="nom">Nom :</label>
        <input type="text" id="nom" name="nom" required pattern="[A-Za-z]+" class="inputVide"><br><br>

        <label for="telephone">Numéro de téléphone :</label>
        <input type="tel" id="telephone" name="telephone" required pattern="[0-9]{10}" class="inputVide"><br><br>

        <label for="codePostal">Code postal :</label>
        <input type="text" id="codePostal" name="codePostal" required pattern="[0-9]{5}" class="inputVide"><br><br>

        <label for="email">Adresse e-mail :</label>
        <input type="email" id="email" name="email" required pattern="^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/" class="inputVide"><br><br>

        <label for="motDePasse">Mot de passe :</label>
        <input type="password" id="motDePasse" name="motDePasse" required class="inputVide"><br><br>
        
        <input type="submit" value="S'inscrire">
       
    </form>
    <?php
    // Include the PHP code here
    // Initialize constants to represent CSS classes for input validation
    $GREEN='inputCorrect';
    $WHITE='inputVide';
    $RED='inputIncorrect';

    // Receive form data
    $listForms = $_POST['form'];

    // Define a list of email addresses for validation
    $listemail = array("example1@example.com", "example2@example.com"); // Modify this list

    // Function to check input field validity
    function InputsCheckValidity($listInputs, &$listInputsValidity, $submit, $formulaire) {
        // Loop through input fields
        foreach ($listInputs as $element) {
            if ($element->checkValidity()) {
                $listInputsValidity[$element->name] = true;
            } else {
                $listInputsValidity[$element->name] = false;
            }
        }

        // Special validation for email address during registration
        verifEmail($listInputsValidity, $formulaire);

        // Special validation for password fields
        verifPassword($listInputsValidity, $formulaire);

        // Change input field styles based on their validity
        changeColor($listInputs, $listInputsValidity);

        // Enable or disable the submit button based on input validity
        revealSubmitButton($listInputsValidity, $submit);
    }

    // Function to check if the provided email exists in the list
    function verifEmail(&$listInputsValidity, $formulaire, $listemail) {
        $mailSaisi = $formulaire->querySelector("#adresseMail");
        $infoMail = $formulaire->querySelector("#infoEmail");
        if ($mailSaisi != null && in_array($mailSaisi->value, $listemail)) {
            $listInputsValidity['adresseMail'] = false;
            $infoMail->classList->remove('noDisplay');
        } elseif ($infoMail != null) {
            $infoMail->classList[] = 'noDisplay';
        }
    }

    // Function to validate password fields
    function verifPassword(&$listInputsValidity, $formulaire) {
        $listePassword = $formulaire->querySelectorAll("input[type=password]");
        if (count($listePassword) == 2 && $listePassword[0]->value != $listePassword[1]->value) {
            $listInputsValidity[$listePassword[1]->name] = false;
        }
    }

    // Function to change input field styles based on validity
    function changeColor($listInputs, $listInputsValidity) {
        foreach ($listInputs as $element) {
            // Remove previously added classes
            $element->classList->remove(GREEN, RED, WHITE);

            // Add appropriate classes based on conditions
            if ($listInputsValidity[$element->name] == true && $element->value != "") {
                $element->classList[] = GREEN;
            } elseif ($listInputsValidity[$element->name] == false && ($element->type == "number" || $element->value != "")) {
                $element->classList[] = RED;
            } else {
                $element->classList[] = WHITE;
            }
        }
    }

    // Function to reset input fields to their default values
    function resetInputs($listInputs, &$listInputsValidity, $submit, $formulaire) {
        foreach ($listInputs as $element) {
            $element->value = $element->defaultValue;
        }

        // Re-run validation for all fields
        InputsCheckValidity($listInputs, $listInputsValidity, $submit, $formulaire);
    }

    // Function to enable/disable the submit button based on input validity
    function revealSubmitButton($listInputsValidity, $submit) {
        // Enable the button by default
        $submit->disabled = false;

        // If any input is not filled correctly, disable the button
        if (in_array(false, $listInputsValidity)) {
            $submit->disabled = true;
        }
    }

    // Function to prevent context menu and paste events
    function annule($event) {
        $event->preventDefault();
    }

    // Function to toggle password visibility
    function affichePassWord($input) {
        $inp = $input->previousElementSibling;

        if ($inp->type == "password") {
            $inp->type = "text";
        } else if ($inp->type == "text") {
            $inp->type = "password";
        }
    }

    // Your code goes here
    ?>
</body>
</html>