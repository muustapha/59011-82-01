using API2.Helpers;
using API2.Models.Dtos;
using API2.Models.data;
using API2.Models.Services;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ArbitresController : ControllerBase
    {
        private readonly ArbitresService _service;
        private readonly IMapper _mapper;

        public ArbitresController(ArbitresService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Arbitres
        [HttpGet]
        public ActionResult<IEnumerable<Arbitre>> GetAllArbitres()
        {
            IEnumerable<Arbitre> listeArbitres = _service.GetAllArbitres();
            return Ok(_mapper.Map<IEnumerable<ArbitresDTO>>(listeArbitres));
        }


        //GET api/Arbitres/{id}
        [HttpGet("{id}", Name = "GetJoById")]
        public ActionResult<ArbitresDTO> GetArbitreById(int id)
        {
            var item = _service.GetArbitreById(id);
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
            return CreatedAtRoute(nameof(GetArbitreById), new { Id = footballPOCO.IdArbitre }, footballPOCO);

        }

        //PUT api/footballs/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateJoueur(int id, ArbitresDTO football)
        {
            var ArbitreFromRepo = _service.GetArbitreById(id);
            if (ArbitreFromRepo == null)
            {
                return NotFound();
            }
            ArbitreFromRepo.Dump();
            _mapper.Map(football, ArbitreFromRepo);
            ArbitreFromRepo.Dump();
            football.Dump();
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdateArbitre(ArbitreFromRepo);

            return NoContent();
        }

        //PATCH api/footballs/{id}

        // Exemple d'appel
        //[{  "op":"replace",
        //    "path":"prenom",
        //    "value":"test"
        //    }]
        [HttpPatch("{id}")]
        public ActionResult PartialArbitreUpdate(int id, JsonPatchDocument<Arbitre> patchDoc)
        {
            patchDoc.Dump();
            var ArbitreFromRepo = _service.GetArbitreById(id);
            if (ArbitreFromRepo == null)
            {
                return NotFound();
            }

            var footballToPatch = _mapper.Map<Arbitre>(ArbitreFromRepo);
            patchDoc.ApplyTo(footballToPatch, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

            if (!TryValidateModel(footballToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(footballToPatch, ArbitreFromRepo);

            _service.UpdateArbitre(ArbitreFromRepo);

            return NoContent();
        }

        //DELETE api/footballs/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteJoueur(int id)
        {
            var ArbitreModelFromRepo = _service.GetArbitreById(id);
            if (ArbitreModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteArbitre(ArbitreModelFromRepo);

            return NoContent();
        }

    }
}