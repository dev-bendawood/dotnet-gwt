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
        public ListResponse<string> Get()
        {
            string address = Login.GetClaimValue(User.Claims, ClaimTypes.Name);
            return new ListResponse<string>(3,  new string[] { "s1", "s2", address });
        }
    }
}