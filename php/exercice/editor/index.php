
<?php


$user1 = new AuthorEditor();
$user1->username = "Balthazar";

$user1 = new MyClass(); // assuming MyClass implements the Editor interface
$user1->setEditorPrivileges(["write text", "add punctuation"]);

$user1 = new MyClass();
$user1->setEditorPrivileges(["edit text", "edit punctuation"]);
