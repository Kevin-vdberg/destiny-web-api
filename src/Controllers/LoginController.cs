using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DestinyWebApi.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public IResult Get()
        {
            IResult result = Results.SignIn(
                    new ClaimsPrincipal(
                        new ClaimsIdentity(
                        new[] { new Claim("user_id", Guid.NewGuid().ToString()) },
                        "cookie")
                        ),
                    authenticationScheme: "cookie");

            return result;

        }
    }
}