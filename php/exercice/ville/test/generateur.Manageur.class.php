<?php

class ManagerGenerator
{
    /**
     * Génère la classe Manageur pour une classe donnée.
     *
     * @param string $className Le nom de la classe pour laquelle générer la classe DAO.
     * @return string Le code source de la classe DAO générée.
     */
    public static function generateManager($className) 
    {

        $code = "<?php\n\n";
        $code .= "class Manager\n{\n\n";
        $code .= "\tpublic static function add(\$class \$obj)\n\t{\n";
        $code .= "\t\treturn DAO::add(\$obj);\n\t}\n\n";
        $code .= "\tpublic static function update(\$class \$obj)\n\t{\n";
        $code .= "\t\treturn DAO::update(\$obj);\n\t}\n\n";
        $code .= "\tpublic static function delete(\$class \$obj)\n\t{\n";
        $code .= "\t\treturn DAO::delete(\$obj);\n\t}\n\n";
        $code .= "\tpublic static function getattributes()\n\t{\n";
        $code .= "\t\treturn \$class::get_attributes();\n\t}\n\n";
        $code .= "\tpublic static function select(\$nomColonnes = null, \$conditions = null, \$orderBy = null, \$limit = null, \$api = false, \$debug = false)\n\t{\n";
        $code .= "\t\treturn DAO::select(\$nomColonnes, \$conditions, \$orderBy, \$limit, \$api, \$debug);\n\t}\n\n";
        $code .= "\tpublic static function findById(\$id)\n\t{\n";
        $code .= "\t\treturn DAO::select(\$class::get_Attributes(), [\"idClass\" => \$id])[0];\n\t}\n\n";
        $code .= "\tpublic static function getList(array \$nomColonnes = null, array \$conditions = null, string \$orderBy = null, string \$limit = null, bool \$api = false, bool \$debug = false)\n\t{\n";
        $code .= "\t\t\$nomColonnes = (\$nomColonnes == null) ? \$class::get_Attributes() : \$nomColonnes;\n";
        $code .= "\t\treturn DAO::select(\$nomColonnes, \$conditions, \$orderBy, \$limit, \$api, \$debug);\n\t}\n\n";
        $code .= "}\n";

        echo $code;
    }
}


$codeGeneré = ManagerGenerator::generateManager("ville");
echo $codeGeneré;