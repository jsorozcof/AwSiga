
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace AwSiga.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        public CommonController() { }


        [HttpGet]
        public async Task<ActionResult<string>> GetTest()
        {
            return "ok";
        }
    }
}
