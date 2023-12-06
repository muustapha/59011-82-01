using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;


namespace GestionCrudMvvm.Models.Profiles
{
    class Profiles :Profile
    {

        public static List<Produit> FromObjectToProduits(List<Object> liste)
        {
            string listeSerialize = JsonConvert.SerializeObject(liste);
            List<Produit> produits = JsonConvert.DeserializeObject<List<Produit>>(listeSerialize);
            return produit;
        }
        public static List<Object> FromProduitsToObject(List<Produit> liste)
        {
            string listeSerialize = JsonConvert.SerializeObject(liste);
            List<Object> objs = JsonConvert.DeserializeObject<List<Object>>(listeSerialize);
            return objs;
        }
    }
}
