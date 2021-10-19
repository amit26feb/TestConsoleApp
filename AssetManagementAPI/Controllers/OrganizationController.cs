using AssetManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        public IOrganizationService _OrganizationService;
        public OrganizationController(IOrganizationService OrganizationService)
        {
            _OrganizationService = OrganizationService;
        }        

        [HttpGet]
        [Route("Assets/{organizationId}")]
        [ProducesResponseType(typeof(List<string>), 200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(500)]
        public IActionResult OrganizationDetails(int organizationId)
        {
            if (organizationId != 0)
            {
                List<string> Organization = _OrganizationService.GetAssets(organizationId);
                if (Organization != null)
                    return Ok(Organization);
                else
                    return NoContent();
            }

            return BadRequest("Invalid Id");
        }
    }
}
