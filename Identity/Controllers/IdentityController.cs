using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetIdentity(string name)
        {
            return Ok(new IdentityDto { Name = name, Age = 51 });
        }


    }
}
