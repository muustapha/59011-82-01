using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace APIfootball
{
   
        [Route("api/Equipes")]
        [ApiController]
        public class EquipesController : ControllerBase
        {
            private readonly EquipesServices _service;
            private readonly IMapper _mapper;

            public EquipesController(EquipesServices service, IMapper mapper)
            {
                _service = service;
                _mapper = mapper;
            }

            //GET api/Equipes
            [HttpGet]
            public ActionResult<IEnumerable<EquipeDTOAvecPartitaEtArbitre>> GetAllEquipes()
            {
                IEnumerable<Equipe> listeEquipes = _service.GetAllEquipes();
                return Ok(_mapper.Map<IEnumerable<EquipeDTOAvecPartitaEtArbitre>>(listeEquipes));
            }

            //GET api/Equipes/{i}
            [HttpGet("{id}", Name = "GetEquipeById")]
            public ActionResult<EquipeDTOAvecPartitaEtArbitre> GetEquipeById(int id)
            {
                Equipe commandItem = _service.GetEquipesById(id);
                if (commandItem != null)
                {
                    return Ok(_mapper.Map<EquipeDTOAvecPartitaEtArbitre>(commandItem));
                }
                return NotFound();
            }

            //POST api/Equipes
            [HttpPost]
            public ActionResult<Equipe> CreateEquipe(EquipeDTOIn obj)
            {
                // avec l'ID dans le DTO In
                //_service.AddEquipes( _mapper.Map<Equipe>(obj));
                //return CreatedAtRoute(nameof(GetEquipeById), new { Id = obj.EquipeId }, obj);


                // sans l'id dans le DTOIn
                Equipe newEquipe = _mapper.Map<Equipe>(obj);
                _service.AddEquipes(newEquipe);
                return CreatedAtRoute(nameof(GetEquipeById), new { Id = newEquipe.IdEquipe }, newEquipe);
            }

            //POST api/Equipes/{id}
            [HttpPut("{id}")]
            public ActionResult UpdateEquipe(int id, EquipeDTOIn obj)
            {
                Equipe objFromRepo = _service.GetEquipesById(id);
                if (objFromRepo == null)
                {
                    return NotFound();
                }
                _mapper.Map(obj, objFromRepo);
                _service.UpdateEquipes(objFromRepo);
                return NoContent();
            }

            // Exemple d'appel
            // [{
            // "op":"replace",
            // "path":"",
            // "value":""
            // }]
            //PATCH api/Equipes/{id}
            [HttpPatch("{id}")]
            public ActionResult PartialEquipeUpdate(int id, JsonPatchDocument<Equipe> patchDoc)
            {
                Equipe objFromRepo = _service.GetEquipesById(id);
                if (objFromRepo == null)
                {
                    return NotFound();
                }
                Equipe objToPatch = _mapper.Map<Equipe>(objFromRepo);
                patchDoc.ApplyTo(objToPatch, ModelState);
                if (!TryValidateModel(objToPatch))
                {
                    return ValidationProblem(ModelState);
                }
                _mapper.Map(objToPatch, objFromRepo);
                _service.UpdateEquipes(objFromRepo);
                return NoContent();
            }

            //DELETE api/Equipes/{id}
            [HttpDelete("{id}")]
            public ActionResult DeleteEquipe(int id)
            {
                Equipe obj = _service.GetEquipesById(id);
                if (obj == null)
                {
                    return NotFound();
                }
                _service.DeleteEquipes(obj);
                return NoContent();
            }


        }
    }
