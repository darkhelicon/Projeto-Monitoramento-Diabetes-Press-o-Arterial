using APIHM.Services.Interfaces;
using APIHM.Validator;
using AutoMapper;
using Common;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIHM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly IUserService _userService;
        public readonly IMapper _mapper;
        public UserController(IPersonService personService,
            IUserService userService, IMapper mapper)
        {
            _personService = personService;
            _userService = userService;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Login(LoginModel user)
        {
            var result = _userService.Login(user);
            if(result != null) 
            {
                return Ok(new
                {
                    UserId = result.Id,
                    PersonId = result.PersonId,
                    Email = result.Person.Email,
                    Username = result.Person.Username
                });

            } else
            {
                return Ok(new { response = "ERROR" });
            }
        }
        [HttpPost("Create")]
        public IActionResult Create(UserModel user)
        {
            UserValidator validator = new UserValidator();
            ValidationResult results = validator.Validate(user);
            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    Console.WriteLine("Property " + item.PropertyName + " failed");
                }
                return Ok(new { response = "ERROR" });
            }
            var personId = _personService.AddPerson(new PersonModel()
            {
                Email = user.Person.Email,
                Username = user.Person.Username,
                HasG = user.Person.HasG,
                HasH = user.Person.HasH,
                Date = user.Person.Date,
            });

            _userService.AddUser(new UserModel()
            {
                PersonId = personId,
                Password = user.Password
            });

            return Ok(new { response = "Está criado" });
        }

        [HttpPatch("Update")]
        public IActionResult Update(UserModel user)
        {
            _userService.UpdateUser(user);
            _personService.UpdatePerson(user.Person);

            return Ok(new { response = "Está atualizado" });
        }
        [HttpPost("Forgot")]
        public IActionResult Forgot([FromBody] string email)
        {
            return Ok(new { response = "Ok" });
        }
        [HttpPost("Reset")]
        public IActionResult Reset(UserModel user)
        {
            return Ok(new { response = "Senha redefinida" });
        }
    }
}
