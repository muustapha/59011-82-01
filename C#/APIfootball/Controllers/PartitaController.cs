using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using static APIfootball.PartitaDTO;


namespace APIfootball
{
  
        [Route("api/[controller]")]
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
            public ActionResult<IEnumerable<PartitaDTOAvecEquipeEtArbitre>> GetAllPartita()
            {
                IEnumerable<Partita> listePartita = _service.GetAllPartita();
                return Ok(_mapper.Map<IEnumerable<PartitaDTOAvecEquipeEtArbitre>>(listePartita));
            }

            //GET api/Partita/{i}
            [HttpGet("{id}", Name = "GetPartitaById")]
            public ActionResult<PartitaDTOAvecEquipeEtArbitre> GetPartitaById(int id)
            {
                Partita commandItem = _service.GetPartitaById(id);
                if (commandItem != null)
                {
                    return Ok(_mapper.Map<PartitaDTOAvecEquipeEtArbitre>(commandItem));
                }
                return NotFound();
            }

           



            //POST api/Partita
            [HttpPost]
            public ActionResult<Partita> CreatePartita(PartitaDTOIn obj)
            {
                Partita newPartita = _mapper.Map<Partita>(obj);
                _service.AddPartita(newPartita);
                return CreatedAtRoute(nameof(GetPartitaById), new { Id = newPartita.IdPartita }, newPartita);
            }

            //POST api/Partita/{id}
            [HttpPut("{id}")]
            public ActionResult UpdatePartita(int id, PartitaDTOIn obj)
            {
                Partita objFromRepo = _service.GetPartitaById(id);
                if (objFromRepo == null)
                {
                    return NotFound();
                }
                _mapper.Map(obj, objFromRepo);
                _service.UpdatePartita(objFromRepo);
                return NoContent();
            }

            // Exemple d'appel
            // [{
            // "op":"replace",
            // "path":"",
            // "value":""
            // }]
            //PATCH api/Partita/{id}
            [HttpPatch("{id}")]
            public ActionResult PartialPartitaUpdate(int id, JsonPatchDocument<Partita> patchDoc)
            {
                Partita objFromRepo = _service.GetPartitaById(id);
                if (objFromRepo == null)
                {
                    return NotFound();
                }
                Partita objToPatch = _mapper.Map<Partita>(objFromRepo);
                patchDoc.ApplyTo(objToPatch, ModelState);
                if (!TryValidateModel(objToPatch))
                {
                    return ValidationProblem(ModelState);
                }
                _mapper.Map(objToPatch, objFromRepo);
                _service.UpdatePartita(objFromRepo);
                return NoContent();
            }

            //DELETE api/Partita/{id}
            [HttpDelete("{id}")]
            public ActionResult DeletePartita(int id)
            {
                Partita obj = _service.GetPartitaById(id);
                if (obj == null)
                {
                    return NotFound();
                }
                _service.DeletePartita(obj);
                return NoContent();
            }


        }
    }

