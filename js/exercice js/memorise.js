var nbrsDeJoueurs = "";
var nbrsDePaires = "";
var nbrsDeMauvaiseTentative = "";
var tempsTentative = "";
var carte = [];
var partieEnCours = false;
var joueurActuel = 1;

const arrayCarte = [1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10];

const imagesCarte = {
    1 : "images/1.jpn",
    2 : "images/2.jpn",
    3: "images/3.jpn",
    4: "images/4.jpn",
    5: "images/5.jpn",
    6: "images/6.jpn",
    7: "images/7.jpn",
    8: "images/8.jpn",
    9: "images/9.jpn",
    10: "images/10.jpn"
};

function randomCard() {
    return Math.floor(Math.random() * arrayCarte.length);
}

function distribuerCarte() {
    for (let i = 0; i < nbrsDePaires; i++) {
        const index = randomCard();
        const carteValeur = arrayCarte.splice(index, 1)[0];
        carte.push(carteValeur);
        carte.push(carteValeur);
    }
}

function afficherJoueurActuel() {
    document.getElementById('joueurActuel').innerHTML = "Joueur " + joueurActuel;
}
init

const nombreJoueursSelect = document.getElementById("nombreJoueurs");
const nombreDePairesSelect = document.getElementById("nombreDePaires");
const startButton = document.getElementById("start");

function activerDemarrerButton() {
    if (nombreJoueursSelect.value !== "0" && nombreDePairesSelect.value !== "0") {
        startButton.disabled = false;
    } else {
        startButton.disabled = true;
    }
}

nombreJoueursSelect.addEventListener("change", activerDemarrerButton);
nombreDePairesSelect.addEventListener("change", activerDemarrerButton);

function démarrer()
{   


    
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

function passerAuJoueurSuivant() {
    joueurActuel = (joueurActuel % nbrsDeJoueurs) + 1;
    afficherJoueurActuel();
}

function init() {
    nbrsDeJoueurs = document.getElementById("nombreJoueurs").value;
    nbrsDePaires = document.getElementById("nombreDePaires").value;
    nbrsDeMauvaiseTentative = prompt("Combien de mauvaise tentative ?");
    tempsTentative = prompt("Combien de temps pour la tentative ?");
    distribuerCarte();
    afficherJoueurActuel();
}

grille = document.getElementById("grille");
temp = document.querySelector("template");

document.getElementById("nombreDePaires").addEventListener("change", function () {
    nbrsDePaires = document.getElementById("nombreDePaires").value;
    resetGrille();
});

function resetGrille() {
    grille.innerHTML = "";
    for (let i = 0; i < nbrsDePaires; i++) {
        const element = temp.content.cloneNode(true);
        element.querySelector('.verso').classList.remove('verso');
        element.querySelector('.verso').classList.add('carte');

        const carteValeur = carte[i];
        const cheminImage = imagesCarte[carteValeur];
        const imgElement = document.createElement("img");
        imgElement.setAttribute("src", cheminImage);

        element.querySelector('.carte').appendChild(imgElement);

        grille.appendChild(element);
    }
}

init();








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
//     grille.innerHTML = grille.innerHTML.replaceAll("verso");
    





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