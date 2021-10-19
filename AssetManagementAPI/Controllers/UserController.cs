using AssetManagementAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AssetManagementAPI.Models;

namespace AssetManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(UserModel), 200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(500)]
        public IActionResult GetUser(int id)
        {
            if (id != 0)
            {
              UserModel user =  _userService.GetUserData(id);
                if (user != null)
                    return Ok(user);
                else
                    return NoContent();
            }

            return BadRequest("Invalid Id");
        }
    }
}
