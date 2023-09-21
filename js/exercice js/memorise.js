var nbrsDeJoueur = "";
var nbrsDeCarte = "";
var nbrsDeMauvaiseTentative = "";
var tempsTentative = "";
var carte = [];
var partieEnCours = false;
var joueurActuel = 1;   
const arrayCarte = [1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8];

function randomCard() {
    return Math.floor(Math.random() * 10) + 1;
}
console.log(randomCard());


function distribuerCarte() {
    for (let i = 0; i < nbrsDeCarte; i++) {
        const index = Math.floor(Math.random() * arrayCarte.length);
        const carteValeur = arrayCarte.splice(index, 1)[0];
        carte.push(carteValeur);
    }
    console.log(carte);
}

function afficherJoueurActuel() {
    document.getElementById('joueurActuel').innerHTML = "Joueur " + joueurActuel;
}


function démarrer() {
    if (!partieEnCours) {
        partieEnCours = true;
        console.log("Début de la partie");
        // Ajoutez ici la logique pour initialiser la partie
    }
    afficherJoueurActuel();
}

function retournerCarte(carte) {
    if (partieEnCours) {
        const verso = carte.querySelector('.verso');
        verso.style.display = 'none';
    }
}

const cartes = document.querySelectorAll(".carte");
cartes.forEach(carte => {
    carte.addEventListener("click", () => {
        démarrer();
        retournerCarte(carte);
    });
});

function passerAuJoueurSuivant() { joueurActuel = (joueurActuel % nbrsDeJoueur) +1;
    afficherJoueurActuel();}

    function init() {
        nbrsDeJoueur = document.getElementById("nombreJoueurs").value;
        nbrsDeCarte = document.getElementById("nombreCartes").value;
        nbrsDeMauvaiseTentative = prompt("Combien de mauvaise tentative ?");
        tempsTentative = prompt("Combien de temps pour la tentative ?");
        distribuerCarte(); afficherJoueurActuel();
    }
    init();

    grille = document.getElementById("carte");

    temp = document.querySelector("template");

    document.getElementById("nombreCartes").addEventListener("change", function () {
        nbrsDeCarte = document.getElementById("nombreCartes").value;
        resetGrille();
    });
  
    function resetGrille() {
        grille.innerHTML = "";
        for (let i = 0; i < nbrsDeCarte; i++) {
            const element = temp.content.cloneNode(true); // on clone le template
            element.querySelector('.verso').classList.remove('verso'); // Supprime la classe "verso"
            element.querySelector('.verso').classList.add('carte'); // Ajoute la classe "carte"
            grille.appendChild(element); // on ajoute l'élément cloné à la grille
        }
    }
    
    





//on recopie le template
// const element = temp.content.cloneNode(true); // on clone le template
// grille.appendChild(element);    // on ajoute la ligne à la grille

// on recopie le template en boucle
// for (let i = 0; i < 10; i++) {
//     const element2 = temp.content.cloneNode(true); // on clone le template
//     grille.appendChild(element2);    // on ajoute la ligne à la grille
// }

// on modifie le template avant de l'ajouter


// for (let i = 0; i < nbrsDeCarte; i++) {
//     const element3 = temp.content.cloneNode(true); // on clone le template
//     grille.appendChild(element3); }   // on ajoute la ligne à la grille
//     grille.innerHTML = grille.innerHTML.replaceAll("verso",