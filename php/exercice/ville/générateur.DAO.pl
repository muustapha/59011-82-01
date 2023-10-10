<?php

class DAOGenerator
{
	/**
	 * Génère la classe DAO pour une classe donnée.
	 *
	 * @param string $className Le nom de la classe pour laquelle générer la classe DAO.
	 * @return string Le code source de la classe DAO générée.
	 */
	public static function generateDAO(string $className): string
	{
		$attributes = self::getClassAttributes($className);

		$code = "<?php\n\n";
		$code .= "class DAO\n{\n\n";
		$code .= "\tpublic static function add(\$obj)\n\t{\n";
		$code .= "\t\t\$db = DbConnect::getDb();\n";
		$code .= "\t\t\$class = get_class(\$obj);\n";
		$code .= "\t\t\$colonnes = \$class::getAttributes();\n";
		$code .= "\t\t\$requ = \"INSERT INTO ville_\" . \$class . \"(\";\n";
		$code .= "\t\t\$values = \"\";\n";
		$code .= "\t\t\$bindValue = [];\n\n";

		$code .= "\t\tfor (\$i = 1; \$i < count(\$colonnes); \$i++) {\n";
		$code .= "\t\t\t\$methode = \"get\" . ucfirst(\$colonnes[\$i]);\n";
		$code .= "\t\t\tif (\$obj->\$methode() !== null) {\n";
		$code .= "\t\t\t\t\$requ .= \$colonnes[\$i] . \",\";\n";
		$code .= "\t\t\t\t\$values .= \":\" . \$colonnes[\$i] . \",\";\n";
		$code .= "\t\t\t}\n";
		$code .= "\t\t}\n\n";

		$code .= "\t\t\$requ = substr(\$requ, 0, strlen(\$requ) - 1);\n";
		$code .= "\t\t\$values = substr(\$values, 0, strlen(\$values) - 1);\n";
		$code .= "\t\t\$requ .= \") VALUES (\" . \$values . \")\";\n";
		$code .= "\t\t\$q = \$db->prepare(\$requ);\n\n";

		$code .= "\t\tfor (\$i = 1; \$i < count(\$colonnes); \$i++) {\n";
		$code .= "\t\t\t\$methode = \"get\" . ucfirst(\$colonnes[\$i]);\n";
		$code .= "\t\t\tif (\$obj->\$methode() !== null)\n";
		$code .= "\t\t\t\t\$q->bindValue(\":\" . \$colonnes[\$i], \$obj->\$methode());\n";
		$code .= "\t\t}\n";
		$code .= "\t\t\$q->execute();\n";
		$code .= "\t\treturn \$db->lastInsertId();\n";
		$code .= "\t}\n\n";

		$code .= "\tpublic static function update(\$obj)\n\t{\n";
		$code .= "\t\t\$db = DbConnect::getDb();\n";
		$code .= "\t\t\$class = get_class(\$obj);\n";
		$code .= "\t\t\$colonnes = \$class::getAttributes();\n";
		$code .= "\t\t\$requ = \"UPDATE ville_\" . \$class . \" SET \";\n\n";

		$code .= "\t\tfor (\$i = 1; \$i < count(\$colonnes); \$i++) {\n";
		$code .= "\t\t\t\$requ .= \$colonnes[\$i] . \"=:\" . \$colonnes[\$i] . \",\";\n";
		$code .= "\t\t}\n";
		$code .= "\t\t\$requ = substr(\$requ, 0, strlen(\$requ) - 1);\n";
		$code .= "\t\t\$requ .= \" WHERE \" . \$colonnes[0] . \"=:\" . \$colonnes[0];\n\n";

		$code .= "\t\t\$q = \$db->prepare(\$requ);\n\n";

		$code .= "\t\tfor (\$i = 0; \$i < count(\$colonnes); \$i++) {\n";
		$code .= "\t\t\t\$methode = \"get\" . ucfirst(\$colonnes[\$i]);\n";
		$code .= "\t\t\t\$q->bindValue(\":\" . \$colonnes[\$i], \$obj->\$methode());\n";
		$code .= "\t\t}\n";
		$code .= "\t\treturn \$q->execute();\n";
		$code .= "\t}\n\n";

		$code .= "\tpublic static function delete(\$obj)\n\t{\n";
		$code .= "\t\t\$db = DbConnect::getDb();\n";
		$code .= "\t\t\$class = get_class(\$obj);\n";
		$code .= "\t\t\$colonnes = \$class::getAttributes();\n";
		$code .= "\t\t\$methode = \"get\" . ucfirst(\$colonnes[0]);\n";
		$code .= "\t\treturn \$db->query(\"DELETE FROM ville_\" . \$class . \" WHERE \" . \$colonnes[0] . \" = \" . \$obj->\$methode());\n";
		$code .= "\t}\n\n";

		$code .= "\tpublic static function count(?array \$nomColonnes = null, string \$ville, ?array \$conditions = null, string \$orderBy = null, string \$limit = null, bool \$api = false, bool \$debug = false)\n\t{\n";
		$code .= "\t\t\$nomColonnes = (\$nomColonnes == null) ? \$ville::getAttributes() : \$nomColonnes;\n";
		$code .= "\t\t\$liste = self::select(\$nomColonnes,  \$ville,  \$conditions,  \$orderBy,  \$limit,  \$api,  \$debug);\n";
		$code .= "\t\tif (\$liste != false)\n\t\treturn count(\$liste);\n";
		$code .= "\t\treturn(0);\n";
		$code .= "\t}\n\n";

		$code .= "\tpublic static function select(?array \$nomColonnes=null, string \$ville, ?array \$conditions = null, string \$orderBy = null, string \$limit = null, bool \$api = false, bool \$debug = false)\n\t{\n";
		$code .= "\t\t\$db = DbConnect::getDb();\n";
		$code .= "\t\t\$nomColonnes = (\$nomColonnes == null) ? \$ville::getAttributes() : \$nomColonnes;\n";
		$code .= "\t\t\$string = json_encode(\$nomColonnes) . \$ville . json_encode(\$conditions) . \$orderBy . \$limit . \$api . \$debug;\n";
		$code .= "\t\tif (strpos((string) \$string, \";\")) {\n";
		$code .= "\t\t\treturn false;\n";
		$code .= "\t\t} else if (!empty(\$nomColonnes)  && (\$ville != null && \$ville != \"\")) {\n\n";

		$code .= "\t\t\t\$cols = self::elementSelect(\$nomColonnes);\n\n";

		$code .= "\t\t\t\$t = \" FROM Ville_\". \$ville;\n\n";

		$code .= "\t\t\tif (\$conditions != null) {\n";
		$code .= "\t\t\t\t\$conditions = self::conditionSelect(\$conditions,\$ville);\n";
		$code .= "\t\t\t}\n";
		$code .= "\t\t\tif (\$orderBy != null) {\n";
		$code .= "\t\t\t\t\$orderBy = \" ORDER BY \" . \$orderBy;\n";
		$code .= "\t\t\t}\n";
		$code .= "\t\t\tif (\$limit != null) {\n";
		$code .= "\t\t\t\t\$limit = \" LIMIT \" . \$limit;\n";
		$code .= "\t\t\t}\n\n";

		$code .= "\t\t\t\$q = \$db->query(\$cols . \$t . \$conditions . \$orderBy . \$limit);\n";
		$code .= "\t\t\tif (\$debug) {\n";
		$code .= "\t\t\t\tvar_dump(\$cols . \$t . \$conditions . \$orderBy . \$limit);\n";
		$code .= "\t\t\t}\n";
		$code .= "\t\t\t\$liste = [];\n";
		$code .= "\t\t\tif (!\$q) return false;\n";
		$code .= "\t\t\twhile (\$donnees = \$q->fetch(PDO::FETCH_ASSOC)) {\n";
		$code .= "\t\t\t\tif (\$donnees != false) {\n";
		$code .= "\t\t\t\t\tif (\$api) {\n";
		$code .= "\t\t\t\t\t\t\$liste[] = \$donnees;\n";
		$code .= "\t\t\t\t\t} else {\n";
		$code .= "\t\t\t\t\t\t\$liste[] = new \$ville(\$donnees);\n";
		$code .= "\t\t\t\t\t}\n";
		$code .= "\t\t\t\t}\n";
		$code .= "\t\t\t}\n";
		$code .= "\t\t\treturn \$liste;\n";
		$code .= "\t\t}\n";
		$code .= "\t\treturn false;\n";
		$code .= "\t}\n\n";

		$code .= "\tprivate static function elementSelect(\$tab)\n\t{\n";
		$code .= "\t\t\$temp = \"SELECT \";\n";
		$code .= "\t\tforeach (\$tab as \$uneCol) {\n";
		$code .= "\t\t\t\$temp .= \$uneCol . \", \";\n";
		$code .= "\t\t}\n";
		$code .= "\t\treturn substr(\$temp, 0, strlen(\$temp) - 2);\n";
		$code .= "\t}\n\n";

		$code .= "\tprivate static function conditionSelect(\$conditions,\$ville)\n\t{\n";
		$code .= "\t\t\$req = \" WHERE \";\n";
		$code .= "\t\tforeach (\$conditions as \$nomColonne => \$valeur) {\n";
		$code .= "\t\t\tif (\$nomColonne != \"fullTexte\") {\n";
		$code .= "\t\t\t\tif (is_array(\$valeur)) {\n";
		$code .= "\t\t\t\t\t\$req .= \$nomColonne . \" IN (\" . implode(\",\", \$valeur) . \") AND \";\n";
		$code .= "\t\t\t\t} else if (!(strpos((string) \$valeur, \"%\") === false)) {\n";
		$code .= "\t\t\t\t\t\$req .= \$nomColonne . ' LIKE \"' . \$valeur . '\" AND ';\n";
		$code .= "\t\t\t\t} else if (strpos((string) \$valeur, \"->\")) {\n";
		$code .= "\t\t\t\t\t\$tab = explode(\"->\", \$valeur);\n";
		$code .= "\t\t\t\t\t\$req .= \$nomColonne . \" BETWEEN \" . \$tab[0] . \" AND \" . \$tab[1] . \" AND \";\n";
		$code .= "\t\t\t\t} else if (is_null(\$valeur)){\n";
		$code .= "\t\t\t\t\t\$req .= \$nomColonne.\" IS NULL AND \";\n";
		$code .= "\t\t\t\t}\n";
		$code .= "\t\t\t\telse {\n";
		$code .= "\t\t\t\t\t\$req .= \$nomColonne . \" = \\\"\" . \$valeur . \"\\\" AND \";\n";
		$code .= "\t\t\t\t}\n";
		$code .= "\t\t\t} elseif(\$valeur!=\"\") {\n";
		$code .= "\t\t\t\t\$rechercheFullTexte=\"\";\n";
		$code .= "\t\t\t\t\$colonnes  = \$ville::getAttributes();\n";
		$code .= "\t\t\t\tforeach (\$colonnes as \$col) {\n";
		$code .= "\t\t\t\t\tif(strtolower(substr(\$col,0,4))!=\"date\")\n";
		$code .= "\t\t\t\t\t\$rechercheFullTexte .= \$col .' like \"%'.\$valeur.'%\" OR ';\n";
		$code .= "\t\t\t\t}\n";
		$code .= "\t\t\t\t\$rechercheFullTexte = substr(\$rechercheFullTexte, 0, strlen(\$rechercheFullTexte) - 3);\n";
		$code .= "\t\t\t\t\$req .= \"(\".\$rechercheFullTexte.\") AND \";\n";
		$code .= "\t\t\t}\n";
		$code .= "\t\t}\n";
		$code .= "\t\t\$req = substr(\$req, 0, strlen(\$req) - 4);\n";
		$code .= "\t\treturn \$req;\n";
		$code .= "\t}\n";
		$code .= "}\n";

		return $code;
	}

	/**
	 * Récupère les attributs d'une classe.
	 *
	 * @param string $className Le nom de la classe.
	 * @return array Les noms des attributs de la classe.
	 */
	private static function getClassAttributes(string $className): array
	{
		$reflectionClass = new ReflectionClass($className);
		$attributes = [];
		foreach ($reflectionClass->getProperties() as $property) {
			$attributes[] = $property->getName();
		}
		return $attributes;
	}
}

echo DAOGenerator::generateDAO('MaClasse');