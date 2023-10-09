<?php

class VilleManager 
{

	public static function add(Ville $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Ville $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Ville $obj)
	{
 		return DAO::delete($obj);
	}
public static function getattributes(){
 return Ville::get_attributes();
}


	// public static function findById($id)
	// {
 	// 	return DAO::select(Ville::getAttributes(),"Ville",["idVille" => $id])[0];
	// }

public function select ($nomColonnes = null, $conditions=null, $orderBy = null, $limit = null, $api = false, $debug = false){

return DAO::select($nomColonnes,"Ville",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );
    }



	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Ville::get_Attributes():$nomColonnes;
		return DAO::select($nomColonnes,"Ville",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}