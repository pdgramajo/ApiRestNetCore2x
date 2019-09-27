using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ApiRestNetCore2x.Models;
using System.ComponentModel.DataAnnotations;

namespace ApiRestNetCore2x.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public RoleController(RoleManager<IdentityRole> roleMgr, IConfiguration configuration)
        {
            _roleManager = roleMgr;
            _configuration = configuration;
        }

        [Route("Create")]
        [HttpPost]
        public async Task<IActionResult> CreateRol([Required]string name)
        {
            if (ModelState.IsValid)
            {
               // var user = new ApplicationUser { UserName = model.Username, Email = model.Email };
               IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(name));
                // var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return Ok(result);//BuildToken(model);
                }
                else
                {
                    return BadRequest("Username or Password invalid");
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}