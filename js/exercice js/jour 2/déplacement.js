// // Récupérer les boutons de direction
const UpButton = document.getElementById('top');
const LeftButton = document.getElementById('left');
const RightButton = document.getElementById('right');
const BottomButton = document.getElementById('bottom');
const carre = document.getElementById('carre');

// Ajouter des gestionnaires d'événements aux boutons
UpButton.addEventListener('click', up); // Appel de la fonction 'up' pour déplacer vers le haut
LeftButton.addEventListener('click', left); // Appel de la fonction 'left' pour déplacer vers la gauche
RightButton.addEventListener('click', right); // Appel de la fonction 'right' pour déplacer vers la droite
BottomButton.addEventListener('click', down); // Appel de la fonction 'down' pour déplacer vers le bas
let x=0;
let y=0;

const step = 20; // Le nombre de pixels à déplacer à chaque clic

// Fonctions pour déplacer le carré en utilisant translate
function up() {
    y -= step;
    carre.style.transform = `translate(${x}px, ${y}px)`;
}

function down() {
    y += step;
    carre.style.transform = `translate(${x}px, ${y}px)`;
}

function left() {
    x -= step;
    carre.style.transform = `translate(${x}px, ${y}px)`;
}

function right() {
    x += step;
    carre.style.transform = `translate(${x}px, ${y}px)`;
}

