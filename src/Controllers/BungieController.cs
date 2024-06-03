using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Destiny;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DestinyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BungieController : ControllerBase 
    {

    [HttpGet("home")]
    //[Authorize(Policy = "bungie-enabled")]
    public string Get()
    {
        PostgreSqlDatabase db = new PostgreSqlDatabase();
            
        return db.GetVersion();
    }

        /*
        // POST api/<BungieController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BungieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BungieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */

    }
}