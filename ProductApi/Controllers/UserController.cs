using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductApi.Models;
using ProductApi.Services;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("PolicyOne")]
    public class UserController : ControllerBase
    {
        private ILoggerManager _logger;
        private IUserService _service;

        public UserController(ILoggerManager logger, IUserService service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/users")]
        public ActionResult<List<User>> GetUsers()
        {
            return _service.GetUsers();
        }

        [HttpGet("/api/users/{id}")]
        public ActionResult<User> GetUser(int id)
        {
            return _service.GetUser(id);
        }

        [HttpPost("/api/users")]
        public ActionResult<User> AddUser(User user)
        {
            return _service.AddUser(user);
        }

        [HttpPut("/api/users/{id}")]
        public ActionResult<User> UpdateUser(User user)
        {
            return _service.UpdateUser(user);
        }

        [HttpDelete("/api/users/{id}")]
        public ActionResult<User> DeleteUser(int id)
        {
            return _service.DeleteUser(id);
        }

    }
}