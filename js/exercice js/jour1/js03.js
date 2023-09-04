
    //    // Changement de couleur des paragraphes
       const paragraphes = document.querySelectorAll("p");
       let couleurIndexParagraphe = 0;

       for (const paragraphe of paragraphes) {
           paragraphe.addEventListener("click", () => {
               const couleurs = ["orange", "purple"];
               couleurIndexParagraphe = (couleurIndexParagraphe + 1) % couleurs.length;
               paragraphe.style.color = couleurs[couleurIndexParagraphe];
           });
       }  
        

         // Version 1 : Changer la couleur de tous les titres en cliquant sur l'un des titres (rotation sur 3 couleurs)
        

        for (const titre of titres) {
            titre.addEventListener("click", () => {
                const couleurs = ["red", "green", "blue"];
                couleurIndex = (couleurIndex + 1) % couleurs.length;
                titre.style.color = couleurs[couleurIndex];
            });
        }