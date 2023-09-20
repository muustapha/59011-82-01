var nbrsDeJoueur ="" ;
var nbrsDeCarte = "";
var nbrsDeMauvaiseTentative = "";
var tempsTentative = "";
var carte = [];

function randomCard() {
    return Math.floor(Math.random() * 10) + 1;
}
   console.log (randomCard);   

function distribuercarte() {
    for (let i = 0; i < nbrsDeCarte; i++) {
        carte.push(randomCard());
    }
    console.log(carte);
}


function init() {
    nbrsDeJoueur = prompt("Combien de joueur ?");
    nbrsDeCarte = prompt("Combien de carte ?");
    nbrsDeMauvaiseTentative = prompt("Combien de mauvaise tentative ?");
    tempsTentative = prompt("Combien de temps pour la tentative ?");
    distribuercarte();
}
init();

grille = document.getElementById("carte");

temp = document.querySelector("template");


//on recopie le template
// const element = temp.content.cloneNode(true); // on clone le template
// grille.appendChild(element);    // on ajoute la ligne à la grille

// on recopie le template en boucle
// for (let i = 0; i < 10; i++) {
//     const element2 = temp.content.cloneNode(true); // on clone le template
//     grille.appendChild(element2);    // on ajoute la ligne à la grille
// }

// on modifie le template avant de l'ajouter


for (let i = 0; i < 10; i++) {
    const element3 = temp.content.cloneNode(true); // on clone le template
    grille.appendChild(element3);    // on ajoute la ligne à la grille
    grille.innerHTML = grille.innerHTML.replaceAll("verso", "carte");
}