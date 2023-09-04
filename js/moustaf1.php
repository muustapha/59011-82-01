<?php

/**
 * Initialize the var of the game
 *
 * @return
 */
function init()
{
        $sizecode =
        $attemptsnbr =
        $colornbr =
        $board = array();
        $init = init();
return 
    $sizecode = initCodeSize();
    $attemptsnbr = initAttemptsNbr();
    $colornbr = initColorNbr();
    $board = initBoard();
}

/**
 * Init the size of the secret code
 *
 * @return integer // size of the code that also the lenght of the board
 */
function initCodeSize()
{
    $sizecode = initCodeSize();
}

/**
 * Init the number of try for this game
 *
 * @return integer // number of try wanted that also the height of the board
 */
function initAttemptsNbr()
{
    $attemptsnbr = initAttemptsNbr();
}
/**
 * InitBoard create an empty board that will be printed each turn
 *
 * @param integer $x lenght / secret code size
 * @param integer $y height / number of try
 * @return array  // array of the board
 */
function initBoard(int $x, int $y)
{
    $board = initBoard($sizecode, $attemptsnbr);
    for ($x= 0; $i < $y; $x++) {
        $board[] = array(
          );
}

/**
 * Init the number of different value that can be in the code
 *
 * @return integer // number of value
 */
function initColorNbr()
{
$colornbr=initColorNbr();}

/**
 * Init a random secret code with code size and the number of different char
 *
 * @param integer $nbColor 
 * @param integer $codeSize
 * @return string $code generated code
 */
function initCode(int $nbColor, int $codeSize)
{
    $initCode=initCode($nbColor, $codeSize);
    
    $initCode = array("red","green","blue","yellow","orange","purple","brown");
$code=array_rand($initCode);
$code=$initCode[$code];}


/**
 * Game loop
 *
 * @param array $board
 * @param integer $nbColor
 * @param string $code
 * @param integer $nbTry
 * @param integer $codeSize
 * @return void
 */
function run(array $board, int $nbColor, int $code, int $nbTry, int $codeSize){
 
  $board=[];
  $nbColor=5;                            
  $code=3;
  $nbTry=10;
  $codeSize=4;
  $run=run($board, $nbColor, $code, $nbTry, $codeSize);}
/**
 * Ask the user to enter a code and verify the compliance of it
 *
 * @param integer $nbColor
 * @param integer $codeSize
 * @return string $attempt last entry of the user
 */
function userInput(int $nbColor, int $codeSize)
{$userinput=userInput($nbColor, $codeSize);}  

do {
    // Demande à l'utilisateur d'entrer le code
    $input = readline("Entrez un code de {$codeSize} chiffres (1 à {$nbColor}): ");

    // Vérifie la longueur du code
    if (strlen($input) !== $codeSize) {
        echo "Le code doit avoir une taille de {$codeSize} chiffres.\n";
        continue;
    }

    // Vérifie si tous les caractères sont des chiffres valides
    if (preg_match('/[^1-' . $nbColor . ']/', $input)) {
        echo "Le code doit être composé de chiffres de 1 à {$nbColor}.\n";
        continue;
    }

    // Le code est valide, retourne l'entrée de l'utilisateur
    return $input;
} while (true);
}


/**
 * Check how many correct colors at the good place and correct color at the wrong
 * place are in the attempt
 *
 * @param string $attempt
 * @param string $code
 * @return string // return the result of the attempt as a string
 */
function checkInput(string $attempt, int $code)
{
    $checkInput=checkInput($attempt, $code);
 $correctPlace = "";
    $correctColor = "";

    for ($i = 0; $i < strlen($attempt); $i++) {
        if ($attempt[$i] === $code[$i]) {
            $correctPlace++;
        } elseif (strpos($code, $attempt[$i]) !== false) {
            $correctColor++;
        }
    }

    return "Correctes à la bonne place : $correctPlace, Correctes à la mauvaise place : $correctColor";
}




/**
 * Display the array of board as a correct board game (with all the attempts)
 *
 * @param array $board
 * @param string $result
 */
function displayBoard(array $board, string $result)
{$displayBoard=displayBoard($board, $result);    
{
    // Vérifie que le nombre de tentatives est égal au nombre de résultats
    if (count($board) !== count($results)) {
        echo "Erreur : Le nombre de tentatives ne correspond pas au nombre de résultats.\n";
        return;
    }

    echo "Tableau de jeu :\n";

    // Affiche les tentatives et les résultats correspondants
    for ($i = 0; $i < count($board); $i++) {
        $attempt = $board[$i];
        $result = $results[$i];

        echo "Tentative " . ($i + 1) . ": $attempt - Résultat : $result\n";
    }
}

/**
 * Check if the number of attemps is equal to 0 OR the last attempt is correct
 *
 * @param integer $nbTry
 * @param string $result
 * @return integer $final = 0 game continue, = 1 game winned, = 2 game lost
 */
function checkWin(int $nbTry, string $result)
{
    $checkWin=checkWin($nbTry, $result);
    
    if ($nbTry === 0) {
        return 2; // Le jeu est perdu car il n'y a plus de tentatives.
    }

    if ($result === str_repeat('B', strlen($result))) {
        return 1; // Le jeu est gagné car la dernière tentative est correcte (tous les éléments sont à la bonne place).
    }

    return 0; // Le jeu continue car le nombre de tentatives restantes n'est pas égal à 0 et la dernière tentative n'est pas correcte.
}


/**
 * Function called at the exit of the game loop, echo win or loose
 *
 * @param integer $final 
 */
function endGame(int $final){
    $endGame=endGame($final);   
    if ($final === 1) {
        echo "Bravo ! Vous avez gagné !\n";
    } elseif ($final === 2) {
        echo "Dommage ! Vous avez perdu !\n";
    }
}
/**
 * Update the board with the last attempt, the attempts left and the result of the attempt
 *
 * @param string $attempt
 * @param string $result
 * @param array  $board
 * @return array $board updated board with the last attempt
 */
function updateBoard(string $attempt, string $result, array $board)
{$board=updateBoard($attempt, $result, $board);
    $board[] = array(
        'attempt' => $attempt,
        'result' => $result,
    );

    return $board;
}}