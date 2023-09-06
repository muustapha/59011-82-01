

// // Récupérer les boutons de direction
const UpButton = document.getElementById('top');
const LeftButton = document.getElementById('left');
const RightButton = document.getElementById('right');
const BottomButton = document.getElementById('bottom');
const carre = document.getElementById('carre');
let y=126;
let x=10.1;
const step = 20; // Le nombre de pixels à déplacer à chaque clic
 
function initPosition() {
    carre.style.transform = `translate(${x}px, ${y}px)`;
}

initPosition();

let isDragging = false; // Indicateur de glissement
let offsetX, offsetY; // Offset pour garder la position relative de la souris par rapport au carré
let mouseX = 0; // Variable pour stocker la position X de la souris
let mouseY = 0; // Variable pour stocker la position Y de la souris




// Ajouter des gestionnaires d'événements aux boutons
UpButton.addEventListener('click', up); // Appel de la fonction 'up' pour déplacer vers le haut
LeftButton.addEventListener('click', left); // Appel de la fonction 'left' pour déplacer vers la gauche
RightButton.addEventListener('click', right); // Appel de la fonction 'right' pour déplacer vers la droite
BottomButton.addEventListener('click', down); // Appel de la fonction 'down' pour déplacer vers le bas

function updatePosition() {
    carre.style.transform = `translate(${x}px, ${y}px)`;
}


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

// Ajouter des gestionnaires d'événements pour les touches fléchées
document.addEventListener('keydown', (event) => {
    if (event.key === 'ArrowUp') {
        up();
    } else if (event.key === 'ArrowDown') {
        down();
    } else if (event.key === 'ArrowLeft') {
        left();
    } else if (event.key === 'ArrowRight') {
        right();
    }
});



carre.style.position = 'absolute';
carre.style.transform = 'translate(0px, 0px)';

// Gestionnaire d'événement pour le mouvement de la souris
document.addEventListener('mousemove', (event) => {
    if (isDragging) {
        const newX = event.clientX - offsetX;
        const newY = event.clientY - offsetY;
        carre.style.transform = `translate(${newX}px, ${newY}px)`;
    }
});
document.addEventListener('mousemove', (event) => {
    if (isDragging) {
        x = event.clientX - offsetX;
        y = event.clientY - offsetY;
        updatePosition();
    }
});
// Gestionnaire d'événement pour le clic de souris enfoncé
carre.addEventListener('mousedown', (event) => {
    isDragging = true;
    const rect = carre.getBoundingClientRect();
    offsetX = event.clientX - rect.left;
    offsetY = event.clientY - rect.top;
    mouseX = x; // Sauvegarde de la position X actuelle du carré
    mouseY = y; // Sauvegarde de la position Y actuelle du carré
});

// Gestionnaire d'événement pour le relâchement du clic de souris
document.addEventListener('mouseup', () => {
    isDragging = false;
});

// Annuler la sélection de texte lors du glissement
carre.addEventListener('dragstart', (event) => {
    event.preventDefault();
});

