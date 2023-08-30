 <?php

    $motComplet = readline("entrer un mot: ");
    $lettre = readline("entrer une lettre:");
  
    $longueurLigne = 11;
    $ligne = str_repeat("_", $longueurLigne);
    
    echo $ligne;








    function motComplet($motComplet)
    {
        $motComplet = 'entrerMotComplet'($motComplet);
    }

    function epeler($mot)
    {
        return substr($mot, 0, 1);
        (substr($mot, 1)
        );
    }




    function entrerLettre($lettre)
    {
        $lettre = 'entrerLettre'($lettre);
    }
    function comparerLettreAuMotComplet($lettre, $mot)
    {
        return $lettre == $mot;
    }

    if ($lettre === $mot) {
        echo ("true");
    } else {
        echo ("false");
    }
