

<?php


class Formulaire{
    private $id;    
    public $nom;
    public $numeroDeTelephone;
    public $codePostal;
    public $email;
    public $motDePasse;
    
    public function __construct($id,$nom,$numeroDeTelephone,$codePostal,$email,$motDePasse){
    $this ->id=$id;
    $this->nom=$nom;
    $this->numeroDeTelephone=$numeroDeTelephone;
    $this->codePostal=$codePostal;
    $this->email=$email;
    $this->motDePasse=$motDePasse;  
     }}
    
        function genererFormulaire($formulaire)
        {
            echo "<form action='formulaire2.php' method='post'>";
            echo "<input type='text' name='nom' placeholder='nom'>";
            echo "<input type='number' name='numeroDeTelephone' placeholder='numeroDeTelephone'>";
            echo "<input type='number' name='codePostal' placeholder='codePostal'>";
            echo "<input type='email' name='email' placeholder='email'>";
            echo "<input type='password' name='motDePasse' placeholder='motDePasse'>";
            echo "<input type='submit' name='submit' value='inscription'>";
            echo "</form>";
    
        }

        genererFormulaire();
    
        function verifierFormulaire ()
        {
            if (isset($_POST['submit'])) {
                if (empty($_POST['nom']) || empty($_POST['numeroDeTelephone']) || empty($_POST['codePostal']) || empty($_POST['email']) || empty($_POST['motDePasse'])) {
                    echo "veuillez remplir tous les champs";
                } else {
                    $nom = $_POST['nom'];
                    $numeroDeTelephone = $_POST['numeroDeTelephone'];
                    $codePostal = $_POST['codePostal'];
                    $email = $_POST['email'];
                    $motDePasse = $_POST['motDePasse'];
                    echo "nom : " . $nom . "<br>";
                    echo "numeroDeTelephone : " . $numeroDeTelephone . "<br>";
                    echo "codePostal : " . $codePostal . "<br>";
                    echo "email : " . $email . "<br>";
                    echo "motDePasse : " . $motDePasse . "<br>";}}}

                    verifierFormulaire();   
?>
