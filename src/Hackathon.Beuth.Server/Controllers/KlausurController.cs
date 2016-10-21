using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Beuth.Server.Controllers
{
    [Route("api/[controller]")]
    public class KlausurController : Controller
    {
        private readonly DataRepository _repository;

        public KlausurController(DataRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Klausur> Get()
        {
            return _repository.Klausur.Values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Klausur Get(int id)
        {
            return _repository.Klausur[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Klausur value)
        {
            _repository.Klausur.Add(value.Id, value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Klausur value)
        {
            _repository.Klausur[id] = value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Klausur.Remove(id);
        }
    }
}
