using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unicorn.Api.DAL;
using Unicorn.Api.Models;
using Unicorn.Api.Services;

namespace Unicorn.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
      
            private readonly IRepository<User> _usersRepository;
            public UsersController(IRepository<User> userRepository)
            {
            _usersRepository = userRepository;
            }
            [HttpGet]
            [Route("")]
            public async Task<ActionResult<IEnumerable<User>>> Get()
            {
                var users = await _usersRepository.GetAll();
                return Ok(users);
            }
    }
    
}
