using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ISongService _songService;
        public ValuesController(ISongService songService)
        {
            _songService = songService;
        }
        // GET: api/Values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _songService.AddSong(new Models.Song
            {
                Title = "Vientos del pueblo",
                Description = "Vientos del pueblo de Ebri Knight",
                Duration = new TimeSpan(0, 3, 25)
            }); 

            return new string[] { "value1", "value2" };
        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
