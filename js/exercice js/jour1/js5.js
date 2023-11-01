var monImage = document.querySelector('img');

monImage.addEventListener('click', function() {
    monImage.style.transition = 'transform 1s';
    monImage.style.transform = 'rotate(180deg)';
    
    setTimeout(function() {
        monImage.style.transition = 'transform 3s'; 
        monImage.style.transform = 'rotate(0deg)'; 
    }, 3000);
});