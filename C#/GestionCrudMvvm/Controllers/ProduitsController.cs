using AutoMapper;
using GestionCrudMvvm.Models;
using GestionCrudMvvm.Models.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCrudMvvm.helpers;


namespace GestionCrudMvvm.controllers 
{
    [Route("api/Produit")]
    [ApiController]
    class ProduitsController : ControllerBase
    {
        private readonly ProduitsService _service;
        private readonly IMapper _mapper;

        public ProduitsController(ProduitsService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Produits
        [HttpGet]
        public ActionResult<IEnumerable<Produit>> GetAllProduits()
        {
            // On appelle le service pour obtenir la liste des produits
            IEnumerable<Produit> listeProduits = _service.GetAllProduits();
            // Je transforme la liste de produits en liste de produitsDto
            IEnumerable<ProduitsDTO> listeProduitsDtos = _mapper.Map<IEnumerable<ProduitsDTO>>(listeProduits);
            // On renvoi Ok pour dire que ca c'ets bien passé (code 200) et la liste des produitsDtos transformé en JSON
            return Ok(listeProduitsDtos);
        }
        //GET api/Produits/{id}
        [HttpGet("{id}", Name = "GetProduitById")]
        public ActionResult<ProduitsDTO> GetProduitById(int id)
        {
            var commandItem = _service.GetProduitById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ProduitsDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/produits
        [HttpPost]
        public ActionResult<ProduitsDTO> CreateProduit(Produit produit)
        {
            //on ajoute l’objet à la base de données
            _service.AddProduits(produit);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetProduitById), new { Id = produit.IdProduit }, produit);

        }



        //PUT api/produits/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateProduit(int id, ProduitsDTO produit)
        {
            var produitFromRepo = _service.GetProduitById(id);
            if (produitFromRepo == null)
            {
                return NotFound();
            }
            produitFromRepo.Dump();
            _mapper.Map(produit, produitFromRepo);
            produitFromRepo.Dump();
            produit.Dump();
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdateProduit(produitFromRepo);

            return NoContent();
        }


        //PATCH api/produits/{id}

        // Exemple d'appel
        //[{  "op":"replace",
        //    "path":"prenom",
        //    "value":"test"
        //    }]

        //[HttpPatch("{id}")]
        //public ActionResult PartialProduitUpdate(int id, JsonPatchDocument<Produit> patchDoc)
        //{
        //    patchDoc.Dump();
        //    var produitFromRepo = _service.GetProduitById(id);
        //    if (produitFromRepo == null)
        //    {
        //        return NotFound();
        //    }

        //    var produitToPatch = _mapper.Map<Produit>(produitFromRepo);
        //    //var produitToPatch = produitFromRepo;
        //    patchDoc.ApplyTo(produitToPatch, ModelState);

        //    if (!TryValidateModel(produitToPatch))
        //    {
        //        return ValidationProblem(ModelState);
        //    }

        //    _mapper.Map(produitToPatch, produitFromRepo);

        //    _service.UpdateProduit(produitFromRepo);

        //    return NoContent();
        //}


        //DELETE api/produits/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteProduit(int id)
        {
            var produitModelFromRepo = _service.GetProduitById(id);
            if (produitModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteProduit(produitModelFromRepo);

            return NoContent();
        }

    }

}
