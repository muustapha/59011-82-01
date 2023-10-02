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
public function setpointDeVie($_pointDeVie)
    {
        $this->_pointDeVie = $_pointDeVie;

        return $this;
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
        
    }}

    
    function lanceDe()
    {
      return  De::lanceDe();
    }
    function estVivant()
    {
        return ($this->_pointDeVie > 0);
        // if ($this->getpointDeVie()>0)
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
        $valjoueur = $this->lanceDe();
        $valmonstre = $monstre->lanceDe();
        echo "le joueur a lancé le dé et a obtenu : " . $valjoueur . "\n";

        if ($valjoueur >= $valmonstre) {
            $monstre->EstVivant = (false);
        } else {
            $this->subitDegats($valmonstre);
        }
    
    }

    function subitDegats($degats)

    {
        if (!$this->bouclierFonctionne()) {
           ( $this->setpointDeVie($this->getpointDeVie() - $degats));
            
    }

        }
    private function bouclierFonctionne()
    {
        $bouclier=$this->lanceDe();
     
       return ($bouclier <= 2);

    }
}
?>