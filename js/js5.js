const myImage = document.getElementById("myImage");
const rotateButton = document.getElementById("rotateButton");

let isRotated = false;

rotateButton.addEventListener("click", () => {
    if (isRotated) {
        // Réafficher l'image d'origine après un délai de 2 secondes (2000 ms)
        setTimeout(() => {
            myImage.style.transform = "rotate(0deg)";
            isRotated = false;
        }, 2000);
    } else {
        // Retourner l'image de 180 degrés avec une animation CSS
        myImage.style.transform = "rotate(180deg)";
        isRotated = true;
    }
});