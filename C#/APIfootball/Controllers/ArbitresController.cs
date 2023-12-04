using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static APIfootball.ArbitreDTO;

namespace APIfootball
{
    [Route("api/[controller]")]
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
        public ActionResult<IEnumerable<ArbitreDTOAvecPartita>> GetAllArbitres()
        {
            IEnumerable<Arbitre> listeArbitres = _service.GetAllArbitre();
            return Ok(_mapper.Map<IEnumerable<ArbitreDTOAvecPartita>>(listeArbitres));
        }

        //GET api/Arbitres/{i}
        [HttpGet("{id}", Name = "GetArbitreById")]
        public ActionResult<ArbitreDTOAvecPartita> GetArbitreById(int id)
        {
            Arbitre commandItem = _service.GetArbitreById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ArbitreDTOAvecPartita>(commandItem));
            }
            return NotFound();
        }

        //POST api/Arbitres
        [HttpPost]
        public ActionResult<Arbitre> CreateArbitre(ArbitreDTOIn obj)
        {
            Arbitre newArbitre = _mapper.Map<Arbitre>(obj);
            _service.AddArbitre(newArbitre);
            return CreatedAtRoute(nameof(GetArbitreById), new { Id = newArbitre.IdArbitre }, newArbitre);
        }

        //POST api/Arbitres/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateArbitre(int id, ArbitreDTOIn obj)
        {
            Arbitre objFromRepo = _service.GetArbitreById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateArbitre(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Arbitres/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialArbitreUpdate(int id, JsonPatchDocument<Arbitre> patchDoc)
        {
            Arbitre objFromRepo = _service.GetArbitreById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Arbitre objToPatch = _mapper.Map<Arbitre>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateArbitre(objFromRepo);
            return NoContent();
        }

        //DELETE api/Arbitres/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteArbitre(int id)
        {
            Arbitre obj = _service.GetArbitreById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteArbitre(obj);
            return NoContent();
        }


    }
}