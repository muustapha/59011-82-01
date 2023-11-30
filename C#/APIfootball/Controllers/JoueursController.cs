

using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace APIfootball
{
    [Route("api/[controller]")]
    [ApiController]
    public class JoueursController : ControllerBase
    {

        private readonly JoueursService _service;
        private readonly IMapper _mapper;

        public JoueursController(JoueursService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Joueurs
        [HttpGet]
        public ActionResult<IEnumerable<JoueurDTOAvecRelation>> GetAllJoueurs()
        {
            IEnumerable<Joueur> listeJoueurs = _service.GetAllJoueurs();
            return Ok(_mapper.Map<IEnumerable<JoueurDTOAvecRelation>>(listeJoueurs));
        }

        //GET api/Joueurs/{i}
        [HttpGet("{id}", Name = "GetJoueurById")]
        public ActionResult<JoueurDTOAvecRelation> GetJoueurById(int id)
        {
            Joueur commandItem = _service.GetJoueurById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<JoueurDTOAvecRelation>(commandItem));
            }
            return NotFound();
        }

        //POST api/Joueurs
        [HttpPost]
        public ActionResult<JoueurDTOOut> CreateJoueur(JoueurDTOIn obj)
        {
            Joueur newJoueur = _mapper.Map<Joueur>(obj);
            _service.AddJoueur(newJoueur);
            return CreatedAtRoute(nameof(GetJoueurById), new { Id = newJoueur.IdJoueur }, newJoueur);
        }

        //POST api/Joueurs/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateJoueur(int id, JoueurDTOIn obj)
        {
            Joueur objFromRepo = _service.GetJoueurById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateJoueur(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Joueurs/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialJoueurUpdate(int id, JsonPatchDocument<Joueur> patchDoc)
        {
            Joueur objFromRepo = _service.GetJoueurById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Joueur objToPatch = _mapper.Map<Joueur>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateJoueur(objFromRepo);
            return NoContent();
        }

        //DELETE api/Joueurs/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteJoueur(int id)
        {
            Joueur obj = _service.GetJoueurById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteJoueur(obj);
            return NoContent();
        }




    }
}
