<?php
class Joueur
{

    /*****************Attributs***************** */
    private $_pointDeVie;
    private $_nom;
    /*****************Accesseurs***************** */
    public function getPointDeVie()
    {
        return $this->_pointDeVie;
    }




    public function getNom()
    {
        return $this->_nom;
    }

    public function setNom($nom)
    {
        $this->_nom = $nom;
    }
    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
        if (!empty($options)) // empty : renvoi vrai si le tableau est vide
        {
            $this->hydrate($options);
        };
    }
    public function hydrate($data)
    {
        foreach ($data as $key => $value) {
            $methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
            if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
            {
                $this->$methode($value);
            }
        }
    }

    /*****************Autres Méthodes***************** */

    // /**
    //  * Transforme l'objet en chaine de caractères
    //  *
    //  * @return String
    //  */
    // public function toString()
    // {
    //     return "";
    // }

    // /**
    //  * Renvoi vrai si l'objet en paramètre est égal à l'objet appelant
    //  *
    //  * @param [type] $obj
    //  * @return bool
    //  */
    // public function equalsTo($obj)
    // {
    //     return true;
    // }
    // /**
    //  * Compare 2 objets
    //  * Renvoi 1 si le 1er est >
    //  *        0 si ils sont égaux
    //  *        -1 si le 1er est <
    //  *
    //  * @param [type] $obj1
    //  * @param [type] $obj2
    //  * @return void
    //  */
    // public static function compareTo($obj1, $obj2)
    // {
    //     return 0;
    // }
    function estVivant()
    {
        return ($this->_pointDeVie > 0);
        // if ($this->_pointDeVie>0)
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        // }
    }

    function attaque($monstre)
    {
        $joueur = self::lancerDe();
        $monstre = $monstre->lancerDe();

        if ($joueur >= $monstre) {
            $monstre->EstVivant = (false);
        } else {
            $joueur->subitDegats();
        }
    }


    function subitDegats($degats)

    {
        $joueur->pointDeVie = -10;
    }


    function bouclierFonctionne()
    {
        $bouclier = self::lancerDe();
        return i($bouclier >= 2);

        //          true;
        //     }
        //     else
        //     {
        //         return false;
        //     }

    }


    function lancerDe()
    {
        De::lancer();
    }
}
