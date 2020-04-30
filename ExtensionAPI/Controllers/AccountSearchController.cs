using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExtensionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class AccountSearchController : ControllerBase
    {
        // GET api/values
        [Route("GetAccountSearch")]
        [HttpPost]

        public async Task<IActionResult> GetAccountSearchTesting([FromBody]string input)
        {
            return new OkObjectResult(input);
        }
    }
}
