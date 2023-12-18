using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfStock.Models.Data;
using WpfStock.Models.Dtos;
using WpfStock.Models.Profiles;
using WpfStock.Models.Services;

namespace WpfStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private readonly CategorieService _service;
        private readonly IMapper _mapper;

        public CategorieController(GestionstocksContext context)
        {
            var contextRead = new GestionstocksContext();
            _service = new CategorieService(context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CategorieProfile>();
            });
            _mapper = config.CreateMapper();
        }


        public IEnumerable<CategorieDTOAvecTypesProduit> GetAllCategorie()
        {
            IEnumerable<Categorie> listeCategories = _service.GetAllCategorie();
            return _mapper.Map<IEnumerable<CategorieDTOAvecTypesProduit>>(listeCategories);
        }



        public ActionResult<CategorieDTOAvecTypesProduit> GetCategorieById(int id)
        {
            var item = _service.GetCategorieById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<CategorieDTOAvecTypesProduit>(item));
            }
            return NotFound();
        }


        public ActionResult<Categorie> CreateCategorie(CategorieDTOIn categorieDTO)
        {
            Categorie categoriePOCO = _mapper.Map<Categorie>(categorieDTO);
            //on ajoute l’objet à la base de données
            _service.AddCategorie(categoriePOCO);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetCategorieById), new { Id = categoriePOCO.IdCategorie }, categoriePOCO);

        }


        public ActionResult UpdateCategorie(int id, CategorieDTOIn categorie)
        {
            var categorieFromRepo = _service.GetCategorieById(id);
            if (categorieFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(categorie, categorieFromRepo);
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdateCategorie(categorieFromRepo);

            return NoContent();
        }

        public ActionResult DeleteCategorie(int id)
        {
            var categorieModelFromRepo = _service.GetCategorieById(id);
            if (categorieModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteCategorie(categorieModelFromRepo);

            return NoContent();
        }

    }
}

