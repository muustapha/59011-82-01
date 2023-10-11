<?php

// Initialise 3 constantes afin d'initialiser les couleurs (la valeur entre "" correspond à la classe css qui sera ajoutée).
const GREEN = "inputCorrect";
const WHITE = "inputVide";
const RED = "inputIncorrect";

/************ FIN API MAIL************/

$listForms = $_POST['form'];

// Récupère tous les inputs du formulaire et effectue une première vérification & ajoute les eventListener sur chacun d'entre eux.
foreach ($listForms as $formulaire) {
    // pour chaque formulaire, on récupère les inputs
    $listInputs = $formulaire->querySelectorAll("input:not([type='submit']):not([type='reset']:not([type='button']),select,textarea");
    $submit = $formulaire->querySelector("input[type='submit'], button[type='submit']");
    $reset = $formulaire->querySelector("input[type='reset']");
    $listInputsValidity = []; // tableau qui contient pour chaque input : vrai si l'input est valide, faux sinon

    // on lance la vérification sur tous les champs du formulaire
    InputsCheckValidity($listInputs, $listInputsValidity, $submit, $formulaire);

    $listePassword = $formulaire->querySelectorAll("input[type=password]");
    foreach ($listePassword as $pwd) {

        // on empeche le copier coller sur les mots de passe
        $pwd->addEventListener('contextmenu', 'annule');
        $pwd->addEventListener("paste", 'annule');

        // on récupère l'input du password ayant le pattern
        $aide = $pwd->getAttribute("pattern");
        if ($aide != null) {
            $pwd->addEventListener("input", function ($event) {
                $aideMdp = document_get_element_by_id("infoMDP");
                $aideMdp->style->display = "flex";
                $lesImages = $aideMdp->getElementsByTagName("i");
                $lesCheck = ["(?=.*[A-Z])", "(?=.*[a-z])", "(?=.*[0-9])", "(?=.*[!@#\$%\^&\*+])", "([a-zA-Z0-9!@#\$%\^&\*+]{8,})"];
                for ($i = 0; $i < count($lesCheck); $i++) {
                    if (preg_match($lesCheck[$i], $pwd->value)) {
                        //la condition est vérifiée, on met la coche verte correspondente
                        $lesImages[$i]->classList[] = "far fa-check-circle fa-green";
                    } else {
                        $lesImages[$i]->classList[] = "far fa-times-circle fa-red";
                    }
                }
            });
        }
            // suppression de l'aide mot de passe quand on quitte le champ
            $pwd->addEventListener("blur", function ($event) {
                document.getElementById("infoMDP")->style->display = "none";
            });
        }
    }

    if ($reset != null) {
        // Initialise le bouton reset
        $reset->addEventListener('click', function () {
            resetInputs($listInputs, $listInputsValidity, $submit, $formulaire);
        });
    }

    foreach ($listInputs as $element) {
        $element->addEventListener('input', function () {
            // on déclenche la vérification sur tous les champs du formulaire à chaque changement d'input
            InputsCheckValidity($listInputs, $listInputsValidity, $submit, $formulaire);
        });
    }
}

/*****************************Mot de passe *************************************/

//gestion de l'oeil dans le mot de passe
$listeOeil = document.getElementsByClassName("oeil");
for ($i = 0; $i < count($listeOeil); $i++) {
    // on affiche un petit oeil qui permet de voir de mot de passe 
    // listeOeil[i].addEventListener("mousedown", function () {
    //     affichePassWord(listeOeil[i],true);
    // });
    // listeOeil[i].addEventListener("mouseup", function () {
    //     affichePassWord(listeOeil[i],false);
    // });
    echo $listeOeil[$i];
    $listeOeil[$i]->addEventListener("click", function () {
        // echo 'click';
        affichePassWord($listeOeil[$i]);
    });
}

/***********************************Function************************************/

/**
 * Vérifie que le pattern de l'input est respecté et que l'input n'est pas vide si il est required.
 * Change l'aspect des inputs en fonction de leur état
 * Active ou pas le bouton submit
 * @param {[object]} listInputs 
 * @param {[]} listInputsValidity 
 * @param {object} submit 
 * @param {object} formulaire 
 */
function InputsCheckValidity($listInputs, &$listInputsValidity, $submit, $formulaire) {
    // Pour chaque input, on vérifie sa validité
    foreach ($listInputs as $element) {
        if ($element->checkValidity()) {
            $listInputsValidity[$element->name] = true;
        } else {
            $listInputsValidity[$element->name] = false;
        }
    }
    // Vérification spéciale pour l'adresse mail à l'inscription
    verifEmail($listInputsValidity, $formulaire);
    // Vérification spéciale pour le mot de passe
    verifPassword($listInputsValidity, $formulaire);
    // Change l'aspect des inputs en fonction de leur état
    changeColor($listInputs, $listInputsValidity);
    // Active ou pas le bouton submit
    revealSubmitButton($listInputsValidity, $submit);
}

/**
 * Vérifie que l'adresse mail entree à l'inscription n'existe pas 
 * @param {[]} listInputsValidity 
 */
function verifEmail(&$listInputsValidity, $formulaire) {
    $mailSaisi = $formulaire->querySelector("#adresseMail");
    $infoMail = $formulaire->querySelector("#infoEmail");
    if ($mailSaisi != null && in_array($mailSaisi->value, $listemail)) {
        $listInputsValidity['adresseMail'] = false;
        $infoMail->classList->remove('noDisplay');
    } else if ($infoMail != null) {
        $infoMail->classList[] = 'noDisplay';
    }
}

/**
 * Vérification du mot de passe et de la confirmation de mot de passe.
 * @param {[]} listInputsValidity 
 * @param {object} formulaire 
 */
function verifPassword(&$listInputsValidity, $formulaire) {
    $listePassword = $formulaire->querySelectorAll("input[type=password]");
    if (count($listePassword) == 2 && $listePassword[0]->value != $listePassword[1]->value) {
        $listInputsValidity[$listePassword[1]->name] = false;
    }
}

/**
 * Change la couleur des inputs en fonction de la validité de l'input.
 * @param {[object]} listInputs 
 * @param {[]} listInputsValidity 
 */
function changeColor($listInputs, $listInputsValidity) {
    foreach ($listInputs as $element) {
        // on enlève les classes déja affectée
        $element->classList->remove(GREEN, RED, WHITE);
        // en fonction des coditions, on ajoute les bonnes classes
        if ($listInputsValidity[$element->name] == true && $element->value != "") {
            $element->classList[] = GREEN;
        } else if ($listInputsValidity[$element->name] == false && ($element->type == "number" || $element->value != "")) {
            $element->classList[] = RED;
        } else {
            $element->classList[] = WHITE;
        }
    }
}

/**
 * Reset tous les inputs du formulaire en m'étant la valeur par default.
 * @param {[object]} listInputs 
 * @param {[]} listInputsValidity 
 * @param {object} submit 
 */
function resetInputs($listInputs, &$listInputsValidity, $submit, $formulaire) {
    foreach ($listInputs as $element) {
        $element->value = $element->defaultValue;
    }
    // on relance la vérification sur tous les champs
    InputsCheckValidity($listInputs, $listInputsValidity, $submit, $formulaire);
}

/**
 * Affiche le button submit si tous les inputs sont correctement remplis.
 * @param {[]} listInputsValidity 
 * @param {object} submit 
 */
function revealSubmitButton($listInputsValidity, $submit) {
    // on active le bouton
    $submit->disabled = false;
    // si un input est mal rempli on désactive le bouton
    if (in_array(false, $listInputsValidity)) {
        $submit->disabled = true;
    }
}

/**
 * Annule l'action associé à la touche ou au clic
 * @param {*} event 
 */
function annule($event) {
    $event->preventDefault();
}

/**
 * Change le type de l'input mot de passe
 * @param {boolean} flag 
 */
// function affichePassWord(input, flag) {
//     inp = input.previousElementSibling;
//     if (flag) inp.type = "text";
//     else inp.type = "password";
// }
function affichePassWord($input) {
    $inp = $input->previousElementSibling;

    if ($inp->type == "password") {
        $inp->type = "text";
    } else if ($inp->type == "text") {
        $inp->type = "password";
    }
}