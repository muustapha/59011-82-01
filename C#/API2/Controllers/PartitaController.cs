using API2.Models.data;
using API2.Models.Dtos;
using API2.Models.Services;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using API2.Helpers;

namespace API2.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PartitaController : ControllerBase
    {
        private readonly PartitaService _service;
        private readonly IMapper _mapper;

        public PartitaController(PartitaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Partita
        [HttpGet]
        public ActionResult<IEnumerable<Partita>> GetAllPartita()
        {
            IEnumerable<Partita> listePartita = _service.GetAllPartita();
            return Ok(_mapper.Map<IEnumerable<PartitaDTO>>(listePartita));
        }


        //GET api/Partita/{id}
        [HttpGet("{id}", Name = "GetPartitaById")]
        public ActionResult<PartitaDTO> GetPartitaById(int id)
        {
            var item = _service.GetPartitaById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<PartitaDTO>(item));
            }
            return NotFound();
        }

        //POST api/footballs
        [HttpPost]
        public ActionResult<PartitaDTO> CreatePartita(PartitaDTO footballDTO)
        {
            Partita footballPOCO = _mapper.Map<Partita>(footballDTO);
            //on ajoute l’objet à la base de données
            _service.AddPartita(footballPOCO);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetPartitaById), new { Id = footballPOCO.IdPartita }, footballPOCO);

        }

        //PUT api/footballs/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePartita(int id, PartitaDTO football)
        {
            var footballFromRepo = _service.GetPartitaById(id);
            if (footballFromRepo == null)
            {
                return NotFound();
            }
            footballFromRepo.Dump();
            _mapper.Map(football, footballFromRepo);
            footballFromRepo.Dump();
            football.Dump();
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdatePartita(footballFromRepo);

            return NoContent();
        }

        //PATCH api/footballs/{id}

        // Exemple d'appel
        //[{  "op":"replace",
        //    "path":"prenom",
        //    "value":"test"
        //    }]

        [HttpPatch("{id}")]
        public ActionResult PartialPartitaUpdate(int id, JsonPatchDocument<Partita> patchDoc)
        {
            patchDoc.Dump();
            var footballFromRepo = _service.GetPartitaById(id);
            if (footballFromRepo == null)
            {
                return NotFound();
            }

            var footballToPatch = _mapper.Map<Partita>(footballFromRepo);
            //var footballToPatch = footballFromRepo;
            patchDoc.ApplyTo(footballToPatch, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

            if (!TryValidateModel(footballToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(footballToPatch, footballFromRepo);

            _service.UpdatePartita(footballFromRepo);

            return NoContent();
        }
        //DELETE api/footballs/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePartita(int id)
        {
            var footballModelFromRepo = _service.GetPartitaById(id);
            if (footballModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeletePartita(footballModelFromRepo);

            return NoContent();
        }

    }
}
