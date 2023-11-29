using API2.Models.data;
using API2.Models.Dtos;
using API2.Models.Services;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class RelationsController : ControllerBase
    {
        private readonly RelationsService _service;
        private readonly IMapper _mapper;

        public RelationsController(RelationsService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Relations
        [HttpGet]
        public ActionResult<IEnumerable<Relation>> GetAllRelations()
        {
            IEnumerable<Relation> listeRelations = _service.GetAllRelations();
            return Ok(_mapper.Map<IEnumerable<RelationsDTO>>(listeRelations));
        }


        //GET api/Relations/{id}
        [HttpGet("{id}", Name = "GetRelationById")]
        public ActionResult<RelationsDTO> GetRelationById(int id)
        {
            var item = _service.GetRelationById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<RelationsDTO>(item));
            }
            return NotFound();
        }

        //POST api/footballs
        [HttpPost]
        public ActionResult<RelationsDTO> CreateRelation(RelationsDTO footballDTO)
        {
            Relation footballPOCO = _mapper.Map<Relation>(footballDTO);
            //on ajoute l’objet à la base de données
            _service.AddRelations(footballPOCO);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetRelationById), new { Id = footballPOCO.IdRelation }, footballPOCO);

        }

        //PUT api/footballs/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateRelation(int id, RelationsDTO football)
        {
            var footballFromRepo = _service.GetRelationById(id);
            if (footballFromRepo == null)
            {
                return NotFound();
            }
            footballFromRepo.Dump();
            _mapper.Map(football, footballFromRepo);
            footballFromRepo.Dump();
            football.Dump();
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdateRelation(footballFromRepo);

            return NoContent();
        }

        //PATCH api/footballs/{id}

        // Exemple d'appel
        //[{  "op":"replace",
        //    "path":"prenom",
        //    "value":"test"
        //    }]

        [HttpPatch("{id}")]
        public ActionResult PartialRelationUpdate(int id, JsonPatchDocument<Relation> patchDoc)
        {
            patchDoc.Dump();
            var footballFromRepo = _service.GetRelationById(id);
            if (footballFromRepo == null)
            {
                return NotFound();
            }

            var footballToPatch = _mapper.Map<Relation>(footballFromRepo);
            //var footballToPatch = footballFromRepo;
            patchDoc.ApplyTo(footballToPatch, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

            if (!TryValidateModel(footballToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(footballToPatch, footballFromRepo);

            _service.UpdateRelation(footballFromRepo);

            return NoContent();
        }
        //DELETE api/footballs/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteRelation(int id)
        {
            var footballModelFromRepo = _service.GetRelationById(id);
            if (footballModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteRelation(footballModelFromRepo);

            return NoContent();
        }

    }
}
