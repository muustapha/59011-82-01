<?php
class Parallelepipede extends Rectangle
{
    private $_hauteur;

    public function getHauteur()
    {
        return $this->_hauteur;
    }

    public function setHauteur($hauteur)
    {
        $this->_hauteur = $hauteur;
    }

    public function volume()
    {
        return $this->aire() * $this->getHauteur();
    }

    public function __toString()
    {
        return "Longueur:".$this->getLongueur()." Largeur:".$this->getLargeur()." Hauteur:".$this->getHauteur()." Volume:".$this->volume();
    }
}
?>