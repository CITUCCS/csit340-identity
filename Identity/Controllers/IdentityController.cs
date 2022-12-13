using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private IAgifyClient _agifyClient;

        public IdentityController(IAgifyClient agifyClient)
        {
            _agifyClient = agifyClient;
        }
    
        [HttpGet]
        public async Task<IActionResult> GetIdentity(string name)
        {
            var response = await _agifyClient.GetAge(name);
            return Ok(response);
        }
    }
}
