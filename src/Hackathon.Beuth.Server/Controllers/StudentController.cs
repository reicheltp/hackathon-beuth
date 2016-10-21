using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Beuth.Server.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly DataRepository _repository;

        public StudentController(DataRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _repository.Students.Values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _repository.Students[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Student value)
        {
            _repository.Students.Add(value.Id, value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Student value)
        {
            _repository.Students[id] = value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Students.Remove(id);
        }
    }
}
