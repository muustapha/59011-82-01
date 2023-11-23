using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonnesApi.data.Dtos;
using PersonnesApi.data.service;

namespace api.Controllers
{
    public class PersonnesControllers
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



            [HttpGet]
            public ActionResult<IEnumerable<PersonnesDTO>> getAllPersonnes()
            {
                var listePersonnes = _service.GetAllPersonnes();
                return Ok(_mapper.Map<IEnumerable<PersonnesDTO>>(listePersonnes));
            }


        }

    }
}


