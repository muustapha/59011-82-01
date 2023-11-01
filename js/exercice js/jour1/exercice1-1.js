

// // Récupérez les éléments img et le bouton par leur ID


// // Récupérez l'élément image de l'ampoule par son ID
// const ampoule = document.querySelector("#ampoule");

// // Créez une variable pour suivre l'état actuel de l'ampoule (allumée ou éteinte)


// // Ajoutez un gestionnaire d'événement au clic sur l'ampoule
// ampoule.addEventListener("click", () => {
//     // Changez l'image de l'ampoule en fonction de son état actuel
//     if (ampoule.getAttribute("src") === "img/ampoule eteinte.png") {
//         ampoule.setAttribute('src', "img/ampoule allumee.png");
//     } else {
//         ampoule.setAttribute('src', "img/ampoule eteinte.png");
//     }
// });
 const ampouleElement = document.getElementById("ampoule");
 const ampoule1Element = document.getElementById("ampoule1");

 const boutonChangerImage = document.getElementById("changerImage");

// Créez une variable pour suivre l'image actuellement affichée
let ampouleEtat = 1; // Commencez avec la première image

// Ajoutez un gestionnaire d'événement au bouton
boutonChangerImage.addEventListener("click", () => {
   



 // Changez la visibilité des deux images pour basculer entre elles
    if (ampouleEtat === 1) {
        ampouleElement.style.display = "none";
        ampoule1Element.style.display = "block";
        ampouleEtat = 2;
    } else {
        ampouleElement.style.display = "block";
        ampoule1Element.style.display = "none";
        ampouleEtat = 1;
    }
});