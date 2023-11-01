// Récupération des éléments HTML
const listeDesserts = document.getElementById("listeDesserts");

const ajouterDessertBtn = document.getElementById("ajouterDessert");

// Fonction pour ajouter un dessert à la liste
function ajouterDessert() {
    const dessert = prompt("Entrez le nom du dessert :");

    if (dessert) {
        const nouveauDessert = document.createElement("li");
        nouveauDessert.textContent = dessert; // Modifiez cette ligne
        listeDesserts.appendChild(nouveauDessert);
    }
}


// Fonction pour supprimer un dessert de la liste
function supprimerDessert(event) {

    event.target.remove();
}

// Ajout d'un gestionnaire d'événement pour le bouton "Ajout d'un dessert"
ajouterDessertBtn.addEventListener("click", ajouterDessert);

// Ajout d'un gestionnaire d'événement pour chaque élément de la liste
listeDesserts.addEventListener("click", supprimerDessert);







