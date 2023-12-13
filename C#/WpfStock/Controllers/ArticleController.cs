using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfStock.Models.Services;

namespace WpfStock.Controllers
{
    class ArticleController
    {
        private readonly ArticleService _service;
        private readonly IMapper _mapper;

        public ArticleController(GestionstocksContext context)
        {
            var contextRead = new GestionstocksDbContext();
            _service = new ArticleService(context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ArticleProfile>();
            });
            _mapper = config.CreateMapper();
        }


        public IEnumerable<ArticleDTO> GetAllArticle()
        {
            IEnumerable<Article> listeArticles = _service.GetAllArticle();
            return _mapper.Map<IEnumerable<ArticleDTO>>(listeArticles);
        }



        public ActionResult<ArticleDTO> GetArticleById(int id)
        {
            var item = _service.GetArticleById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<ArticleDTO>(item));
            }
            return NotFound();
        }


        public ActionResult<ArticleDTO> CreateArticle(ArticleDTO personneDTO)
        {
            Article personnePOCO = _mapper.Map<Article>(personneDTO);
            //on ajoute l’objet à la base de données
            _service.AddArticle(personnePOCO);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetArticleById), new { Id = personnePOCO.IdArticle }, personnePOCO);

        }


        public ActionResult UpdateArticle(int id, ArticleDTO personne)
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

