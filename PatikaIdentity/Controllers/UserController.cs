using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PatikaIdentity.Context;
using PatikaIdentity.Entites;
using PatikaIdentity.Request;

namespace PatikaIdentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly PatikaIdentityDbContext _next;
        private readonly IDataProtector _protector;

        public UserController(PatikaIdentityDbContext next,IDataProtectionProvider dataProtectionProvider)
        {
            _next=next;
            _protector = dataProtectionProvider.CreateProtector("security");
        }


        [HttpPost("create")]
        public async Task<IActionResult> Create(UserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { message = "Kullanıcı oluşturulamadı"});
            }
            

            var user = new UserEntitiy
            {
                Email = request.Email,
                Password=_protector.Protect(request.Password),
               
            };

            _next.User.Add(user);
            await _next.SaveChangesAsync();

            return Ok(user);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }




    }
}
