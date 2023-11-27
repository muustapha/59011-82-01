using API.DATA.Dtos;
using API.DATA.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnesController : ControllerBase
    {
        private readonly PersonnesServices _service;
        private readonly IMapper _mapper;
        public PersonnesController(PersonnesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        //GET api/personnes
        [HttpGet]
        public ActionResult<IEnumerable<PersonnesDTO>> getAllPersonnes()
        {
            var listePersonnes = _service.GetAllPersonnes();
            return Ok(_mapper.Map<IEnumerable<PersonnesDTO>>(listePersonnes));
        }

    }
}
