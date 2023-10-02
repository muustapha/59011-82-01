<?php
class PhasePoule extends Tournoi
{

    /*****************Attributs***************** */
 private $_equipes = [];

    /*****************Accesseurs***************** */

    
    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
        if (!empty($options)) // empty : renvoi vrai si le tableau est vide
        {
            $this->hydrate($options);
        }
    }
    public function hydrate($data)
    {
        foreach ($data as $key => $value)
        {
            $methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
            if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
            {
                $this->$methode($value);
            }
        }
    }

    /*****************Autres Méthodes***************** */
  
        /**
         * Fait jouer chaque équipe de la poule contre toutes les autres équipes.
         *
         * @return array Un tableau des résultats des matchs.
         */
        public function jouerMatchs()
        {
            $resultats = []; // tableau pour stocker les résultats des matchs
    
            // parcourir chaque équipe dans la poule
            for ($i = 0; $i < count($this->_equipes); $i++) {
                $equipe1 = $this->_equipes[$i];
    
                // jouer contre toutes les autres équipes dans la poule
                for ($j = $i + 1; $j < count($this->_equipes); $j++) {
                    $equipe2 = $this->_equipes[$j];

                     // simuler le match et stocker le résultat
                    SelectionnerArbitres()                  
                    $resultat = $this->simulerMatch($equipe1, $equipe2);
                    $resultats[] = [
                        'equipe1' => $equipe1,
                        'equipe2' => $equipe2,
                        'resultat' => $resultat
                    ];
                }
            }
    
            return $resultats;
        }
    
 function simulerMatch($equipe1, $equipe2)
        {
            // calculer le score de chaque équipe
            $score1 = $equipe1->getScore();
            $score2 = $equipe2->getScore();
    
            // comparer les scores pour déterminer le gagnant
            if ($score1 > $score2) {
                $equipe1->gagner();
                $equipe2->perdre();
                return $equipe1;
            } else if ($score1 < $score2) {
                $equipe1->perdre();
                $equipe2->gagner();
                return $equipe2;
            } else {
                return null;
            }
        }



}