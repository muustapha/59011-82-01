<script>
       




// Récupérez l'élément image et le bouton par leur ID
const imageElement = document.getElementById("image");
const boutonChangerImage = document.getElementById("changerImage");

// Créez un tableau avec les URL des deux images que vous souhaitez afficher
const images = ["image1.jpg", "image2.jpg"];
let currentIndex = 0; // Indice de l'image actuellement affichée

// Ajoutez un gestionnaire d'événement au bouton
boutonChangerImage.addEventListener("click", () => {
    // Basculez entre les deux images en alternance
    currentIndex = 1 - currentIndex;
    
    // Changez la source de l'image pour afficher l'image suivante
    imageElement.src = images[currentIndex];
});



       </script>