
// //    // Changement de couleur des paragraphes
// const paragraphes = document.querySelectorAll("p");
// let couleurIndexParagraphe = 0;

// for (const paragraphe of paragraphes) {
//     paragraphe.addEventListener("click", () => {
//         const couleurs = ["orange", "purple"];
//         couleurIndexParagraphe = (couleurIndexParagraphe + 1) % couleurs.length;
//         paragraphe.style.color = couleurs[couleurIndexParagraphe];
//     });
// }


// // Version 1 : Changer la couleur de tous les titres en cliquant sur l'un des titres (rotation sur 3 couleurs)
// const titre1 = document.querySelectorAll("h1");
// const titre2 = document.querySelectorAll("h2");
// const titre3 = document.querySelectorAll("h3");

// let couleurIndexH1 = 0;
// let couleurIndexH2 = 0;
// let couleurIndexH3 = 0;

// const titres = document.querySelectorAll("h1, h2, h3");
// let couleurIndex = 0;
// for (const titre of titres) {
//     titre.addEventListener("click", () => {
//         const couleurs = ["red", "green", "blue"];
//         couleurIndex = (couleurIndex + 1) % couleurs.length;
//         titre.style.color = couleurs[couleurIndex];
//     });//    // Changement de couleur des paragraphes
const paragraphes = document.querySelectorAll("p");
let couleurIndexParagraphe = 0;

for (const paragraphe of paragraphes) {
    paragraphe.addEventListener("click", () => {
        const couleurs = ["orange", "purple"];
        couleurIndexParagraphe = (couleurIndexParagraphe + 1) % couleurs.length;
        paragraphe.style.color = couleurs[couleurIndexParagraphe];
    });
}






// Version 1 : Changer la couleur de tous les titres en cliquant sur l'un d'eux (rotation sur 3 couleurs)
const couleurs = ["red", "green", "blue"];
const titres = document.querySelectorAll("h1, h2, h3"); // Remplacez "h1", "h2", "h3" par les sélecteurs appropriés pour vos titres

let couleurIndex = 0;

// Fonction pour mettre à jour la couleur de tous les titres.
function changerCouleurTitres() {
    titres.forEach((titre) => {
        titre.style.color = couleurs[couleurIndex];
    });

    // Incrémentez l'index de couleur pour la prochaine fois.
    couleurIndex = (couleurIndex + 1) % couleurs.length;
}

// Ajoutez un gestionnaire d'événement "click" à chaque titre.
titres.forEach((titre) => {
    titre.addEventListener("click", changerCouleurTitres);
});

// Version 2 : Changer la couleur du titre cliqué (rotation sur 3 couleurs)
const couleurs = ["red", "green", "blue"];
   

