<?php
class Poule
{

    /*****************Attributs***************** */
    private $_nom;
    private $_nbrEquipes = [] ; 
    private $_nbrDePoule;


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
 
    
public static function tiragePoule(array $equipes, int $nbPoules)
{
    // Mélanger le tableau d'équipes aléatoirement
    shuffle($equipes);

    // Calculer le nombre d'équipes par poule
    $nbEquipesParPoule = count($equipes) / $nbPoules;

    // Initialiser le tableau de poules
    $poules = array();

    // Répartir les équipes dans les différentes poules
    for ($i = 0; $i < $nbPoules; $i++) {
        $poule = array();

        // Ajouter les équipes à la poule
        for ($j = 0; $j < $nbEquipesParPoule; $j++) {
            $poule[] = array_pop($equipes);
        }

        // Ajouter la poule au tableau de poules
        $poules[] = $poule;
    }

    return $poules;
}


    private $_equipes; // tableau des équipes dans la poule

    // ...

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


<?php




//     /**
//      * Transforme l'objet en chaine de caractères
//      *
//      * @return String
//      */
//     public function toString()
//     {
//         return "";
//     }

//     /**
//      * Renvoi vrai si l'objet en paramètre est égal à l'objet appelant
//      *
//      * @param [type] $obj
//      * @return bool
//      */
//     public function equalsTo($obj)
//     {
//         return true;
//     }
//     /**
//      * Compare 2 objets
//      * Renvoi 1 si le 1er est >
//      *        0 si ils sont égaux
//      *        -1 si le 1er est <
//      *
//      * @param [type] $obj1
//      * @param [type] $obj2
//      * @return void
//      */
//     public static function compareTo($obj1, $obj2)
//     {
//         return 0;
//     }
// }