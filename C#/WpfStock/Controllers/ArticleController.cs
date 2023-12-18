using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfStock.Models.Dtos;
using WpfStock.Models.Profiles;
using WpfStock.Models.Services;

namespace WpfStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    class ArticleController
    {
        private readonly ArticleService _service;
        private readonly IMapper _mapper;

        public ArticleController(GestionstocksContext context)
        {
            var contextRead = new GestionstocksContext();
            _service = new ArticleService(context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ArticleProfile>();
            });
            _mapper = config.CreateMapper();
        }


        public IEnumerable<ArticleDTOAvecCategorie> GetAllArticle()
        {
            IEnumerable<Categorie> listeArticles = _service.GetAllArticle();
            return _mapper.Map<IEnumerable<ArticleDTOAvecCategorie>>(listeArticles);
        }



        public ActionResult<ArticleDTOAvecCategorie> GetArticleById(int id)
        {
            var item = _service.GetArticleById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<ArticleDTOAvecCategorie>(item));
            }
            return NotFound();
        }


        public ActionResult<Article> CreateArticle(ArticleDTOIn personneDTO)
        {
            Categorie personnePOCO = _mapper.Map<Categorie>(personneDTO);
            //on ajoute l’objet à la base de données
            _service.AddArticle(personnePOCO);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetArticleById), new { Id = personnePOCO.IdArticle }, personnePOCO);

        }


        public ActionResult UpdateArticle(int id, ArticleDTOIn personne)
        {
            var personneFromRepo = _service.GetArticleById(id);
            if (personneFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(personne, personneFromRepo);
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdateArticle(personneFromRepo);

            return NoContent();
        }

        public ActionResult DeleteArticle(int id)
        {
            var personneModelFromRepo = _service.GetArticleById(id);
            if (personneModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteArticle(personneModelFromRepo);

            return NoContent();
        }

    }
}

