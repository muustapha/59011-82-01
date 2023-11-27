using API1.Helpers;
using API1.Models;
using API1.Models.data.Services;
using API1.Models.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ArbitresController : ControllerBase
    {
        private readonly ArbitresServices _service;
        private readonly IMapper _mapper;

        public ArbitresController(ArbitresServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Arbitres
        [HttpGet]
        public ActionResult<IEnumerable<Joueur>> GetAllArbitres()
        {
            IEnumerable<Arbitre> listeArbitres = _service.GetAllArbitres();
            return Ok(_mapper.Map<IEnumerable<ArbitresDTO>>(listeArbitres));
        }


        //GET api/Arbitres/{id}
        [HttpGet("{id}", Name = "GetJoueurById")]
        public ActionResult<ArbitresDTO> GetJoueurById(int id)
        {
            var item = _service.GetJoueurById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<ArbitresDTO>(item));
            }
            return NotFound();
        }

        //POST api/footballs
        [HttpPost]
        public ActionResult<ArbitresDTO> CreateArbitre(ArbitresDTO arbitresDTO)
        {
            Arbitre footballPOCO = _mapper.Map<Arbitre>(arbitresDTO);
            //on ajoute l’objet à la base de données
            _service.AddArbitres(footballPOCO);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetJoueurById), new { Id = footballPOCO.IdArbitre }, footballPOCO);

        }

        //PUT api/footballs/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateJoueur(int id, ArbitresDTO football)
        {
            var footballFromRepo = _service.GetJoueurById(id);
            if (footballFromRepo == null)
            {
                return NotFound();
            }
            footballFromRepo.Dump();
            _mapper.Map(football, footballFromRepo);
            footballFromRepo.Dump();
            football.Dump();
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdateArbitre(footballFromRepo);

            return NoContent();
        }

        //PATCH api/footballs/{id}

        // Exemple d'appel
        //[{  "op":"replace",
        //    "path":"prenom",
        //    "value":"test"
        //    }]

        [HttpPatch("{id}")]
        public ActionResult PartialJoueurUpdate(int id, JsonPatchDocument<Joueur> patchDoc)
        {
            patchDoc.Dump();
            var footballFromRepo = _service.GetJoueurById(id);
            if (footballFromRepo == null)
            {
                return NotFound();
            }

            var footballToPatch = _mapper.Map<Joueur>(footballFromRepo);
            //var footballToPatch = footballFromRepo;
            patchDoc.ApplyTo(footballToPatch, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

            if (!TryValidateModel(footballToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(footballToPatch, footballFromRepo);

            _service.UpdateArbitre(footballFromRepo);

            return NoContent();
        }
        //DELETE api/footballs/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteJoueur(int id)
        {
            var footballModelFromRepo = _service.GetJoueurById(id);
            if (footballModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteArbitre(footballModelFromRepo);

            return NoContent();
        }

    }
}
