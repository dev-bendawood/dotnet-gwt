using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using JwtExample.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtExample
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "manager")]
        public IEnumerable<string> Get()
        {
            string address=Login.GetClaimValue(User.Claims, ClaimTypes.Name);
           //string address="123";
            return new string[] { "s1", "s2", address };
        }
    }
}