<?php

class TriangleRectangle
{

    /*****************Attributs***************** */
    private $_base;
    private $_hauteur;

    /*****************Accesseurs***************** */
    public function getBase()
    {
        return $this->_base;
    }

    public function setBase($base)
    {
        $this->_base = $base;
    }

    public function getHauteur()
    {
        return $this->_hauteur;
    }

    public function setHauteur($hauteur)
    {
        $this->_hauteur = $hauteur;
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
    
   
    function perimetre () {
       return  $this->_base+$this->_hauteur+sqrt($this->_base+$this->_hauteur);
        }
        
        function aire () {
        
      return   ($this->_base+$this->_hauteur)/2;
       
        }
        
        function __toString()
        {
            return "base:".$this->_base.
            "hauteur:".$this->_hauteur.
            "Périmètre:".$this->perimetre().
            "Aire:" .$this->aire();
        }
}
?>
