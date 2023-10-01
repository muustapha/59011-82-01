<?php
class Tournoi
{

    /*****************Attributs***************** */
    private $_nom;
    private $_dateDebut;
    private $_dateFin;
    private $_arbitre=[];
    private $_Equipe ;
    private $_poule;
    
    

    /*****************Accesseurs***************** */
    /**
     * Get the value of _nom
     */ 
    public function get_nom()
    {
        return $this->_nom;
    }

    /**
     * Set the value of _nom
     *
     * @return  self
     */ 
    public function set_nom($_nom)
    {
        $this->_nom = $_nom;

        return $this;
    }

    /**
     * Get the value of _dateDebut
     */ 
    public function get_dateDebut()
    {
        return $this->_dateDebut;
    }

    /**
     * Set the value of _dateDebut
     *
     * @return  self
     */ 
    public function set_dateDebut($_dateDebut)
    {
        $this->_dateDebut = $_dateDebut;

        return $this;
    }

    /**
     * Get the value of _dateFin
     */ 
    public function get_dateFin()
    {
        return $this->_dateFin;
    }

    /**
     * Set the value of _dateFin
     *
     * @return  self
     */ 
    public function set_dateFin($_dateFin)
    {
        $this->_dateFin = $_dateFin;

        return $this;
    }

    /**
     * Get the value of _arbitre
     */ 
    public function get_arbitre()
    {
        return $this->_arbitre;
    }

    /**
     * Set the value of _arbitre
     *
     * @return  self
     */ 
    public function set_arbitre( Arbitre $arbitre)
    {
        $this->_arbitre = $arbitre;

        return $this;
    }

    /**
     * Get the value of _Equipe
     */ 
    public function get_Equipe()
    {
        return $this->_Equipe;
    }

    /**
     * Set the value of _Equipe
     *
     * @return  self
     */ 
    public function set_Equipe(Equipe $Equipe)
    {
        $this->_Equipe = $Equipe;

        return $this;
    }

    /**
     * Get the value of _poule
     */ 
    public function get_poule()
    {
        return $this->_poule;
    }

    /**
     * Set the value of _poule
     *
     * @return  self
     */ 
    public function set_poule(Poule $poule)
    {
        $this->_poule = $poule;

        return $this;
    }
    
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

    public static function SelectionnerArbitres()
    { 
        $arbitres = Tournoi::get_arbitre();
    

        // Sélectionner un arbitre central aléatoirement
        $arbitreCentral = $arbitres[array_rand($arbitres)];
    
        // Sélectionner deux arbitres de touche aléatoirement
        $arbitresDeTouche = array_rand($arbitres, 2);
    
        // Faire quelque chose avec les équipes et les arbitres sélectionnés
    }
}





















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

