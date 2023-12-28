using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFGestionStock1.Models;
using WPFGestionStock1.Models.Data;
using WPFGestionStock1.Models.Dtos;
using WPFGestionStock1.Models.Profiles;
using WPFGestionStock1.Models.Services;

namespace WPFGestionStock1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TypesProduitController : ControllerBase
    {
        private readonly TypesProduitService _service;
        private readonly IMapper _mapper;
        //private GestionstocksContext context;

        public TypesProduitController(GestionstocksContext context)
        {
            //var contextRead = new GestionstocksContext();
            _service = new TypesProduitService(context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<TypesProduitProfile>();
            });
            _mapper = config.CreateMapper();
        }

        //public TypesProduitController(GestionstocksContext context)
        //{
        //    this.context = context;
        //}

        public IEnumerable<TypesProduitDTOAvecCategorie> GetAllTypesProduit()
        {
            IEnumerable<TypesProduit> listeTypesProduits = (IEnumerable<TypesProduit>)_service.GetAllTypesProduit();
            return _mapper.Map<IEnumerable<TypesProduitDTOAvecCategorie>>(listeTypesProduits);
        }



        public ActionResult<TypesProduitDTOAvecCategorie> GetTypesProduitById(int id)
        {
            var item = _service.GetTypesProduitById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<TypesProduitDTOAvecCategorie>(item));
            }
            return NotFound();
        }


        public ActionResult<TypesProduit> CreateTypesProduit(TypesProduitDTOIn typesProduitDTO)
        {
            TypesProduit typesProduitPOCO = _mapper.Map<TypesProduit>(typesProduitDTO);
            //on ajoute l’objet à la base de données
            _service.AddTypesProduit(typesProduitPOCO);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetTypesProduitById), new { Id = typesProduitPOCO.IdTypeProduit }, typesProduitPOCO);

        }


        public ActionResult UpdateTypesProduit(int id, TypesProduitDTOIn typesProduit)
        {
            var typesProduitFromRepo = _service.GetTypesProduitById(id);
            if (typesProduitFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(typesProduit, typesProduitFromRepo);
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdateTypesProduit(typesProduitFromRepo);

            return NoContent();
        }

        public ActionResult DeleteTypesProduit(int id)
        {
            var typesProduitModelFromRepo = _service.GetTypesProduitById(id);
            if (typesProduitModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteTypesProduit(typesProduitModelFromRepo);

            return NoContent();
        }

    }
}


