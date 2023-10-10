<?php
class Paramètre
{

    /*****************Attributs***************** */
    private $_host;
    private $_port;
    private $_dbname;
    private $_user;
    private $_password;
    private $_nbLigne;
    private $_init;



    /*****************Accesseurs***************** */
/**
     * Get the value of _host
     */ 
    public function get_host()
    {
        return $this->_host;
    }

    /**
     * Set the value of _host
     *
     * @return  self
     */ 
    public function set_host($_host)
    {
        $this->_host = $_host;

        return $this;
    }

    /**
     * Get the value of _port
     */ 
    public function get_port()
    {
        return $this->_port;
    }

    /**
     * Set the value of _port
     *
     * @return  self
     */ 
    public function set_port($_port)
    {
        $this->_port = $_port;

        return $this;
    }

    /**
     * Get the value of _dbname
     */ 
    public function get_dbname()
    {
        return $this->_dbname;
    }

    /**
     * Set the value of _dbname
     *
     * @return  self
     */ 
    public function set_dbname($_dbname)
    {
        $this->_dbname = $_dbname;

        return $this;
    }

    /**
     * Get the value of _user
     */ 
    public function get_user()
    {
        return $this->_user;
    }

    /**
     * Set the value of _user
     *
     * @return  self
     */ 
    public function set_user($_user)
    {
        $this->_user = $_user;

        return $this;
    }

    /**
     * Get the value of _password
     */ 
    public function get_password()
    {
        return $this->_password;
    }

    /**
     * Set the value of _password
     *
     * @return  self
     */ 
    public function set_password($_password)
    {
        $this->_password = $_password;

        return $this;
    }

    /**
     * Get the value of _nbLigne
     */ 
    public function get_nbLigne()
    {
        return $this->_nbLigne;
    }

    /**
     * Set the value of _nbLigne
     *
     * @return  self
     */ 
    public function set_nbLigne($_nbLigne)
    {
        $this->_nbLigne = $_nbLigne;

        return $this;
    }

    /**
     * Get the value of _init
     */ 
    public function get_init()
    {
        return $this->_init;
    }

    /**
     * Set the value of _init
     *
     * @return  self
     */ 
    public function set_init($_init)
    {
        $this->_init = $_init;

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

    
}

