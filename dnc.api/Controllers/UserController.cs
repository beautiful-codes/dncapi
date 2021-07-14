using dnc.api.Constant;
using dnc.api.Persistance.Models;
using dnc.api.Repository.user;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;
using System.Collections.Generic;
using System.Security.Claims;

namespace dnc.api.Controllers
{
    //[Authorize(Policy = AuthConstant.MainPolicy)]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        static readonly string[] scopeRequiredByApi = new string[] { "access_as_user" };
        private readonly ILogger<UserController> _logger;
        private readonly IUserRepository _repository;
        public UserController(ILogger<UserController> logger, IUserRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(scopeRequiredByApi);
            string owner = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return _repository.GetAll();
        }
    }
}