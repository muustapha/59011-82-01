using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfStock.Models.Services;

namespace WpfStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private readonly CategorieService _service;
        private readonly IMapper _mapper;

        public CategorieController(CategorieService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Categorie
        [HttpGet]
        public ActionResult<IEnumerable<GradeDTOAvecStudents>> GetAllCategorie()
        {
            IEnumerable<Grade> listeCategorie = _service.GetAllGrade();
            return Ok(_mapper.Map<IEnumerable<GradeDTOAvecStudents>>(listeCategorie));
        }

        //GET api/Categorie/{i}
        [HttpGet("{id}", Name = "GetGradeById")]
        public ActionResult<GradeDTOAvecStudents> GetGradeById(int id)
        {
            Grade commandItem = _service.GetGradeById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<GradeDTOAvecStudents>(commandItem));
            }
            return NotFound();
        }

        //POST api/Categorie
        [HttpPost]
        public ActionResult<Grade> CreateGrade(GradeDTOIn obj)
        {
            Grade newGrade = _mapper.Map<Grade>(obj);
            _service.AddGrade(newGrade);
            return CreatedAtRoute(nameof(GetGradeById), new { Id = newGrade.GradeId }, newGrade);
        }

        //POST api/Categorie/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateGrade(int id, GradeDTOIn obj)
        {
            Grade objFromRepo = _service.GetGradeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateGrade(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Categorie/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialGradeUpdate(int id, JsonPatchDocument<Grade> patchDoc)
        {
            Grade objFromRepo = _service.GetGradeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Grade objToPatch = _mapper.Map<Grade>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateGrade(objFromRepo);
            return NoContent();
        }

        //DELETE api/Categorie/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteGrade(int id)
        {
            Grade obj = _service.GetGradeById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteGrade(obj);
            return NoContent();
        }


    }
}
