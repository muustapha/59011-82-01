<?php
class Sphere extends Cercle
{

    /*****************Attributs***************** */
    private $_volume;

    /*****************Accesseurs***************** */
       
    public function getVolume()
    {
        return $this->_volume;
    }

    public function setVolume($volume)
    {
        $this->_volume = $volume;
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
    public function volume()
    {       // 4/3 PI R3
        return 4/3*pi()*pow($this->getRayon(),3);
    }
}
?>