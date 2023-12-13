using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WpfDbPersonne.Models.Data;
using WpfDbPersonne.Models.Profiles;
using WpfDbPersonne.Models.Dtos;

namespace WpfDbPersonne.Models.Controllers
{
    public class PersonneController : ControllerBase
    {
        private readonly PersonneService _service;
        private readonly IMapper _mapper;

        public PersonneController(PersonneDbContext context)
        {
            var contextRead = new PersonneDbContext();
            _service = new PersonneService(context, contextRead);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<PersonneProfile>();
            });
            _mapper = config.CreateMapper();
        }


        public IEnumerable<PersonneDTO> GetAllPersonne()
        {
            IEnumerable<Personne> listePersonnes = _service.GetAllPersonne();
            return _mapper.Map<IEnumerable<PersonneDTO>>(listePersonnes);
        }



        public ActionResult<PersonneDTO> GetPersonneById(int id)
        {
            var item = _service.GetPersonneById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<PersonneDTO>(item));
            }
            return NotFound();
        }


        public ActionResult<PersonneDTO> CreatePersonne(PersonneDTO personneDTO)
        {
            Personne personnePOCO = _mapper.Map<Personne>(personneDTO);
            //on ajoute l’objet à la base de données
            _service.AddPersonne(personnePOCO);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetPersonneById), new { Id = personnePOCO.IdPersonne }, personnePOCO);

        }


        public ActionResult UpdatePersonne(int id, PersonneDTO personne)
        {
            var personneFromRepo = _service.GetPersonneById(id);
            if (personneFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(personne, personneFromRepo);
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdatePersonne(personneFromRepo);

            return NoContent();
        }

        public ActionResult DeletePersonne(int id)
        {
            var personneModelFromRepo = _service.GetPersonneById(id);
            if (personneModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeletePersonne(personneModelFromRepo);

            return NoContent();
        }

    }
}
