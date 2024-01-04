using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFGestionStock1.Models.Dtos;
using WPFGestionStock1.Models.Data;
using WPFGestionStock1.Models.Profiles;
using WPFGestionStock1.Models.Services;
using WPFGestionStock1.Models;

namespace WPFGestionStock1.Controllers
{
    
    public class ArticleController : ControllerBase
    {
        private readonly ArticleService _service;
        private readonly IMapper _mapper;

        public ArticleController(GestionstocksContext context)
        {
            //var contextRead = new GestionstocksContext();
            _service = new ArticleService(context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ArticleProfile>();
            });
            _mapper = config.CreateMapper();
        }


        public IEnumerable<ArticleDTOAvecCategorie> GetAllArticle()
        {
            IEnumerable<Article> listeArticles = (IEnumerable<Article>)_service.GetAllArticle();

          

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


        public ActionResult<Article> CreateArticle(ArticleDTOIn articleDTO)
        {
            Article articlePOCO = _mapper.Map<Article>(articleDTO);
            //on ajoute l’objet à la base de données
            _service.AddArticle(articlePOCO);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetArticleById), new { Id = articlePOCO.IdArticle }, articlePOCO);

        }


        public ActionResult UpdateArticle(int id, ArticleDTOIn article)
        {
            var articleFromRepo = _service.GetArticleById(id);
            if (articleFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(article, articleFromRepo);
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdateArticle(articleFromRepo);

            return NoContent();
        }

        public ActionResult DeleteArticle(int id)
        {
            var articleModelFromRepo = _service.GetArticleById(id);
            if (articleModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteArticle(articleModelFromRepo);

            return NoContent();
        }

    }
}

