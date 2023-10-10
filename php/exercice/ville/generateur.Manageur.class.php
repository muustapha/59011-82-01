<?php

class ManageurGenerator
{
	/**
	 * Génère la classe Manageur pour une classe donnée.
	 *
	 * @param string $className Le nom de la classe pour laquelle générer la classe DAO.
	 * @return string Le code source de la classe DAO générée.
	 */
	public static function generateManageur(string $className): string
	{
		$attributes = self::getClassAttributes($className);

$code = "<?php\n\n";
$code .= "class VilleManager\n{\n\n";
$code .= "\tpublic static function add(Ville \$obj)\n\t{\n";
$code .= "\t\treturn DAO::add(\$obj);\n\t}\n\n";
$code .= "\tpublic static function update(Ville \$obj)\n\t{\n";
$code .= "\t\treturn DAO::update(\$obj);\n\t}\n\n";
$code .= "\tpublic static function delete(Ville \$obj)\n\t{\n";
$code .= "\t\treturn DAO::delete(\$obj);\n\t}\n\n";
$code .= "\tpublic static function getattributes()\n\t{\n";
$code .= "\t\treturn Ville::get_attributes();\n\t}\n\n";
$code .= "\tpublic static function select(\$nomColonnes = null, \$conditions = null, \$orderBy = null, \$limit = null, \$api = false, \$debug = false)\n\t{\n";
$code .= "\t\treturn DAO::select(\$nomColonnes, \$conditions, \$orderBy, \$limit, \$api, \$debug);\n\t}\n\n";
$code .= "\tpublic static function findById(\$id)\n\t{\n";
$code .= "\t\treturn DAO::select(Ville::get_Attributes(), [\"idVille\" => \$id])[0];\n\t}\n\n";
$code .= "\tpublic static function getList(array \$nomColonnes = null, array \$conditions = null, string \$orderBy = null, string \$limit = null, bool \$api = false, bool \$debug = false)\n\t{\n";
$code .= "\t\t\$nomColonnes = (\$nomColonnes == null) ? Ville::get_Attributes() : \$nomColonnes;\n";
$code .= "\t\treturn DAO::select(\$nomColonnes, \$conditions, \$orderBy, \$limit, \$api, \$debug);\n\t}\n\n";
$code .= "}\n";

    }}
echo $code;