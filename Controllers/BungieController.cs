using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DestinyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BungieController : ControllerBase 
    {

    [HttpGet("home")]
    public string Get()
    {
        return "Hello world!";
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