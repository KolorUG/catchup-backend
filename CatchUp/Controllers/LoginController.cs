using Microsoft.AspNetCore.Mvc;
using CatchUp.ReposInterfaces;

namespace CatchUp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;
        private static string _password;
        public LoginController(ILoginRepository loginRepository)
        {
            this._loginRepository = loginRepository;
        }
        [HttpGet]
        public ActionResult Login([FromBody]string login, string password)
        {
            IUser user = _loginRepository.GetUserByLogin(login);
        }
    }
}