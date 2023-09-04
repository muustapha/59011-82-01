

// Récupérez l'élément image de l'ampoule par son ID
const ampoule = document.querySelector("#ampoule");

// Créez une variable pour suivre l'état actuel de l'ampoule (allumée ou éteinte)


// Ajoutez un gestionnaire d'événement au clic sur l'ampoule
ampoule.addEventListener("click", () => {
    // Changez l'image de l'ampoule en fonction de son état actuel
    if (ampoule.getAttribute("src") === "img/ampoule eteinte.png") {
        ampoule.setAttribute('src', "img/ampoule allumee.png");
    } else {
        ampoule.setAttribute('src',"img/ampoule eteinte.png");
    }
});


