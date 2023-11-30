using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace APIfootball
{
    public class RelationsController
    {

        [Route("api/[controller]")]
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
            public ActionResult<IEnumerable<RelationDTOAvecEquipeEtJoueur>> GetAllRelations()
            {
                IEnumerable<Relation> listeRelations = _service.GetAllRelations();
                return Ok(_mapper.Map<IEnumerable<RelationDTOAvecEquipeEtJoueur>>(listeRelations));
            }

            //GET api/Relations/{i}
            [HttpGet("{id}", Name = "GetRelationById")]
            public ActionResult<RelationDTOAvecEquipeEtJoueur> GetRelationById(int id)
            {
                Relation commandItem = _service.GetRelationById(id);
                if (commandItem != null)
                {
                    return Ok(_mapper.Map<RelationDTOAvecEquipeEtJoueur>(commandItem));
                }
                return NotFound();
            }

            //POST api/Relations
            [HttpPost]
            public ActionResult<RelationDTOOut> CreateRelation(RelationDTOIn obj)
            {
                Relation newObj = _mapper.Map<Relation>(obj);
                _service.AddRelation(newObj);
                return CreatedAtRoute(nameof(GetRelationById), new { Id = newObj.IdRelation }, newObj);
            }

            //POST api/Relations/{id}
            [HttpPut("{id}")]
            public ActionResult UpdateRelation(int id, RelationDTOIn obj)
            {
                Relation objFromRepo = _service.GetRelationById(id);
                if (objFromRepo == null)
                {
                    return NotFound();
                }
                _mapper.Map(obj, objFromRepo);
                _service.UpdateRelation(objFromRepo);
                return NoContent();
            }

            // Exemple d'appel
            // [{
            // "op":"replace",
            // "path":"",
            // "value":""
            // }]
            //PATCH api/Relations/{id}
            [HttpPatch("{id}")]
            public ActionResult PartialRelationUpdate(int id, JsonPatchDocument<Relation> patchDoc)
            {
                Relation objFromRepo = _service.GetRelationById(id);
                if (objFromRepo == null)
                {
                    return NotFound();
                }
                Relation objToPatch = _mapper.Map<Relation>(objFromRepo);
                patchDoc.ApplyTo(objToPatch, ModelState);
                if (!TryValidateModel(objToPatch))
                {
                    return ValidationProblem(ModelState);
                }
                _mapper.Map(objToPatch, objFromRepo);
                _service.UpdateRelation(objFromRepo);
                return NoContent();
            }

            //DELETE api/Relations/{id}
            [HttpDelete("{id}")]
            public ActionResult DeleteRelation(int id)
            {
                Relation obj = _service.GetRelationById(id);
                if (obj == null)
                {
                    return NotFound();
                }
                _service.DeleteRelation(obj);
                return NoContent();
            }


        }
    }
