  <?php
class Paramètre
{

    /*****************Attributs***************** */
    private static $_host;
    private static $_port;
    private static $_dbname;
    private static $_user;
    private static $_password;
    private static $_nbLigne;
    private static $_init;



    /*****************Accesseurs***************** */

    /**
     * Set the value of _host
     *
     * @return  self
     */ 
    public function set_host($_host)
    {
    
        return    self::$_host;
    }

    /**
     * Set the value of _dbname
     *
     * @return  self
     */ 
    public function set_dbname($_dbname)
    {
     return    self::$_dbname;

    }

    /**
     * Set the value of _user
     *
     * @return  self
     */ 
    public function set_user($_user)
    {
      return   self::$_user;


    }

    /**
     * Set the value of _password
     *
     * @return  self
     */ 
    public function set_password($_password)
    {
        return    self::$_password;
    }

    /**
     * Set the value of _nbLigne
     *
     * @return  self
     */ 
    public function set_nbLigne($_nbLigne)
    {
   return     self::$_nbLigne;
    }

    /**
     * Set the value of _init
     *
     * @return  self
     */ 
    public function set_init($_init)
    {
    return    self::$_init;

    }

    /**
     * Set the value of _port
     *
     * @return  self
     */ 
    public function set_port($_port)
    {
     return   self::$_port;
    }
    /**
     * Get the value of _host
     */
    public function get_host()
    {
        return self::$_host;
    }

    /**
     * Get the value of _port
     */
    public function get_port()
    {
        return self::$_port;
    }

    /**
     * Get the value of _dbname
     */
    public function get_dbname()
    {
        return self::$_dbname;
    }




    /**
     * Get the value of _password
     */
    public function get_password()
    {
        return self::$_password;
    }

    /**
     * Get the value of _nbLigne
     */
    public function get_nbLigne()
    {
        return self::$_nbLigne;
    }

    /**
     * Get the value of _init
     */
    public function get_init()
    {
        return self::$_init;
    }

    public function get_user()
    {
        return self::$_user;
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
        foreach ($data as $key => $value) {
            $methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
            if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
            {
               $this->$$methode($value);
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



    public static function init()
    {
        $jsonstr = file_get_contents("parametre.json");
        $config = json_decode($jsonstr, true);
        self::$_host = $config["host"];
        self::$_port = $config["port"];
        self::$_dbname = $config["dbname"];
        self::$_user = $config["user"];
        self::$_password = $config["password"];
        self::$_nbLigne = $config["nbLigne"];
        self::$_init = $config["init"];
    }

}
