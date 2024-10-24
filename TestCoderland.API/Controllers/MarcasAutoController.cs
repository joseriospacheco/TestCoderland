using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestCoderland.Core.Abstractions.Services;
using TestCoderland.Core.Entities;

/*
using TestCoderland.Core.Abstractions.Services;
using TestCoderland.Core.Entities;

*/

namespace TestCoderland.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasAutoController : ControllerBase
    {

        /*
        [HttpGet]
        public ActionResult Get() {

            return Ok("OK");
        }
        */
      

        private readonly IMarcaAutoService _service;


      public MarcasAutoController(IMarcaAutoService service)
      {
          _service = service;
      }

      [HttpGet]
      public async Task<List<MarcaAuto>> Get()
      {
          return await _service.Listar();

      }

    }
}
