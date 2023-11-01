<?php
class Pyramide extends TriangleRectangle
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
        return $this->aire() * $this->getHauteur() / 3;
    }

    public function __toString()
    {
        return "Base:".$this->getBase()." Hauteur:".$this->getHauteur()." Volume:".$this->volume();
    }
}

class Sphere
{
    private $_rayon;

    public function getRayon()
    {
        return $this->_rayon;
    }

    public function setRayon($rayon)
    {
        $this->_rayon = $rayon;
    }

    public function volume()
    {
        return 4 / 3 * pi() * pow($this->getRayon(), 3);
    }

    public function aire()
    {
        return 4 * pi() * pow($this->getRayon(), 2);
    }

    public function __toString()
    {
        return "Rayon:".$this->getRayon()." Volume:".$this->volume()." Aire:".$this->aire();
    }
}?>