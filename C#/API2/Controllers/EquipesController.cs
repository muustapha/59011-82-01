using API2.Helpers;
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
    public class EquipesController : ControllerBase
    {
        private readonly EquipesService _service;
        private readonly IMapper _mapper;

        public EquipesController(EquipesService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Equipes
        [HttpGet]
        public ActionResult<IEnumerable<Equipe>> GetAllEquipes()
        {
            IEnumerable<Equipe> listeEquipes = _service.GetAllEquipes();
            return Ok(_mapper.Map<IEnumerable<EquipesDTO>>(listeEquipes));
        }


        //GET api/Equipes/{id}
        [HttpGet("{id}", Name = "GetEquipeById")]
        public ActionResult<EquipesDTO> GetEquipeById(int id)
        {
            var item = _service.GetEquipeById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<EquipesDTO>(item));
            }
            return NotFound();
        }

        //POST api/footballs
        [HttpPost]
        public ActionResult<EquipesDTO> CreateEquipe(EquipesDTO footballDTO)
        {
            Equipe footballPOCO = _mapper.Map<Equipe>(footballDTO);
            //on ajoute l’objet à la base de données
            _service.AddEquipes(footballPOCO);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetEquipeById), new { Id = footballPOCO.IdEquipe }, footballPOCO);

        }

        //PUT api/footballs/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateEquipe(int id, EquipesDTO football)
        {
            var footballFromRepo = _service.GetEquipeById(id);
            if (footballFromRepo == null)
            {
                return NotFound();
            }
            footballFromRepo.Dump();
            _mapper.Map(football, footballFromRepo);
            footballFromRepo.Dump();
            football.Dump();
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdateEquipe(footballFromRepo);

            return NoContent();
        }

        //PATCH api/footballs/{id}

        // Exemple d'appel
        //[{  "op":"replace",
        //    "path":"prenom",
        //    "value":"test"
        //    }]

        [HttpPatch("{id}")]
        public ActionResult PartialEquipeUpdate(int id, JsonPatchDocument<Equipe> patchDoc)
        {
            patchDoc.Dump();
            var footballFromRepo = _service.GetEquipeById(id);
            if (footballFromRepo == null)
            {
                return NotFound();
            }

            var footballToPatch = _mapper.Map<Equipe>(footballFromRepo);
            //var footballToPatch = footballFromRepo;
            patchDoc.ApplyTo(footballToPatch, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

            if (!TryValidateModel(footballToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(footballToPatch, footballFromRepo);

            _service.UpdateEquipe(footballFromRepo);

            return NoContent();
        }
        //DELETE api/footballs/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteEquipe(int id)
        {
            var footballModelFromRepo = _service.GetEquipeById(id);
            if (footballModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteEquipe(footballModelFromRepo);

            return NoContent();
        }

    }
}