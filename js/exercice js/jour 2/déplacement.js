updatePosition

// // Récupérer les boutons de direction
const UpButton = document.getElementById('top');
const LeftButton = document.getElementById('left');
const RightButton = document.getElementById('right');
const BottomButton = document.getElementById('bottom');
const carre = document.getElementById('carre');

const step = 5; // Le nombre de pixels à déplacer à chaque clic

let y = 103;
let x = 20;


let isDragging = false; // Indicateur de glissement
let offsetX, offsetY; // Offset pour garder la position relative de la souris par rapport au carré
let mouseX = 0; // Variable pour stocker la position X de la souris
let mouseY = 0; // Variable pour stocker la position Y de la souris
function updatePosition() {
    carre.style.transform = `translate(${x}px, ${y}px)`;
}

updatePosition()

// Ajouter des gestionnaires d'événements aux boutons
UpButton.addEventListener('click', up); // Appel de la fonction 'up' pour déplacer vers le haut
LeftButton.addEventListener('click', left); // Appel de la fonction 'left' pour déplacer vers la gauche
RightButton.addEventListener('click', right); // Appel de la fonction 'right' pour déplacer vers la droite
BottomButton.addEventListener('click', down); // Appel de la fonction 'down' pour déplacer vers le bas


updatePosition();

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

// fonction collision

function collision() {
    const carre = document.getElementById('carre');
    const carreRect = carre.getBoundingClientRect();
    
    const obstacles = document.querySelectorAll('.obstacle');
    for (const obstacle of obstacles) {
        const obstacleRect = obstacle.getBoundingClientRect();
        if (
            !(carreRect.top > obstacleRect.bottom ||
            carreRect.bottom < obstacleRect.top ||
            carreRect.right < obstacleRect.left ||
            carreRect.left > obstacleRect.right)
        ) {
            return true;
        }
    }
    return false;
}

// collision avec touches du clavier

document.addEventListener('keydown', (event) => {
    if (collision()) {
        switch (event.key) {
            case 'ArrowUp':
                y += 10;
                break;
            case 'ArrowDown':
                y -= 10;
                break;
            case 'ArrowLeft':
                x += 10;
                break;
            case 'ArrowRight':
                x -= 10;
                break;
        }
        updatePosition();
    }
});

// collision avec flèches à l'écran

UpButton.addEventListener('click', () => {
    if (collision()) {
        y += 10;
        updatePosition();
    }
});

BottomButton.addEventListener('click', () => {
    if (collision()) {
        y -= 10;
        updatePosition();
    }
});

LeftButton.addEventListener('click', () => {
    if (collision()) {
        x += 10;
        updatePosition();
    }
});

RightButton.addEventListener('click', () => {
    if (collision()) {
        x -= 10;
        updatePosition();
    }
});

// collision avec glissement de la souris

document.addEventListener('mousemove', (event) => {
    if (isDragging) {
        x = event.clientX - offsetX;
        y = event.clientY - offsetY;
        if (collision()) {
            x = mouseX;
            y = mouseY;
        }
        updatePosition();
    }
});

// collision avec clic de souris enfoncé   

carre.addEventListener('mousedown', (event) => {
    isDragging = true;
    const rect = carre.getBoundingClientRect();
    offsetX = event.clientX - rect.left;
    offsetY = event.clientY - rect.top;
    mouseX = x;
    mouseY = y;
    if (collision()) {
        x = mouseX;
        y = mouseY;
    }
    updatePosition();
});     


// collision avec relâchement du clic de souris 

document.addEventListener('mouseup', () => {
    isDragging = false;
    updatePosition();
});     


// collision avec annulation de la sélection de texte lors du glissement

carre.addEventListener('dragstart', (event) => {
    event.preventDefault();
    updatePosition();
});

