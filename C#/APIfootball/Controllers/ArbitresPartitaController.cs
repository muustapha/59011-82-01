using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace APIfootball.Controllers
{
 {
        [Route("api/[controller]")]
    [ApiController]

    public class ArbitresPartitaController : ControllerBase
    {


            private readonly ArbitresPartitaService _service;
            private readonly IMapper _mapper;

            public ArbitresPartitaController(ArbitresPartitaService service, IMapper mapper)
            {
                _service = service;
                _mapper = mapper;
            }

            //GET api/ArbitresPartita
            [HttpGet]
            public ActionResult<IEnumerable<ArbitresPartitaDTOAvecArbitreEtPartita>> GetAllArbitresPartita()
            {
                IEnumerable<ArbitresPartita> listeArbitresPartita = _service.GetAllArbitresPartita();
                return Ok(_mapper.Map<IEnumerable<ArbitresPartitaDTOAvecArbitreEtPartita>>(listeArbitresPartita));
            }

            //GET api/ArbitresPartita/{i}
            [HttpGet("{id}", Name = "GetArbitresPartitaById")]
            public ActionResult<ArbitresPartitaDTOAvecArbitreEtPartita> GetArbitresPartitaById(int id)
            {
                ArbitresPartita commandItem = _service.GetArbitresPartitaById(id);
                if (commandItem != null)
                {
                    return Ok(_mapper.Map<ArbitresPartitaDTOAvecArbitreEtPartita>(commandItem));
                }
                return NotFound();
            }

            //POST api/ArbitresPartita
            [HttpPost]
            public ActionResult<ArbitresPartitaDTOOut> CreateArbitresPartita(ArbitresPartitaDTOIn obj)
            {
                ArbitresPartita newObj = _mapper.Map<ArbitresPartita>(obj);
                _service.AddArbitresPartita(newObj);
                return CreatedAtRoute(nameof(GetArbitresPartitaById), new { Id = newObj.IdArbitresPartita }, newObj);
            }

            //POST api/ArbitresPartita/{id}
            [HttpPut("{id}")]
            public ActionResult UpdateArbitresPartita(int id, ArbitresPartitaDTOIn obj)
            {
                ArbitresPartita objFromRepo = _service.GetArbitresPartitaById(id);
                if (objFromRepo == null)
                {
                    return NotFound();
                }
                _mapper.Map(obj, objFromRepo);
                _service.UpdateArbitresPartita(objFromRepo);
                return NoContent();
            }

            // Exemple d'appel
            // [{
            // "op":"replace",
            // "path":"",
            // "value":""
            // }]
            //PATCH api/ArbitresPartita/{id}
            [HttpPatch("{id}")]
            public ActionResult PartialArbitresPartitaUpdate(int id, JsonPatchDocument<ArbitresPartita> patchDoc)
            {
                ArbitresPartita objFromRepo = _service.GetArbitresPartitaById(id);
                if (objFromRepo == null)
                {
                    return NotFound();
                }
                ArbitresPartita objToPatch = _mapper.Map<ArbitresPartita>(objFromRepo);
                patchDoc.ApplyTo(objToPatch, ModelState);
                if (!TryValidateModel(objToPatch))
                {
                    return ValidationProblem(ModelState);
                }
                _mapper.Map(objToPatch, objFromRepo);
                _service.UpdateArbitresPartita(objFromRepo);
                return NoContent();
            }

            //DELETE api/ArbitresPartita/{id}
            [HttpDelete("{id}")]
            public ActionResult DeleteArbitresPartita(int id)
            {
                ArbitresPartita obj = _service.GetArbitresPartitaById(id);
                if (obj == null)
                {
                    return NotFound();
                }
                _service.DeleteArbitresPartita(obj);
                return NoContent();
            }


        }
    }
