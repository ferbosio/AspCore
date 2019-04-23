using System.Threading.Tasks;
using AppPruebaAspCore.API.Data;
using AppPruebaAspCore.API.Dtos;
using AppPruebaAspCore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppPruebaAspCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;
        public AuthController(IAuthRepository repository)
        {
            this._repository = repository;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if (await this._repository.UserExists(userForRegisterDto.Username))
                return BadRequest("Username already exists");

            var userToCreate = new User()
            {
                Username = userForRegisterDto.Username
            };

            var createdUser = await this._repository.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
        }
    }
}