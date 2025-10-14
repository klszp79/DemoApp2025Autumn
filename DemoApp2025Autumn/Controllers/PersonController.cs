using Microsoft.AspNetCore.Mvc;

namespace DemoApp2025Autumn.App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public List<Person> Get()
        {
            return _personService.GetPeople();
        }

        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _personService.GetPersonById(id);
        }

        [HttpPost]
        public void Post([FromBody] Person person)
        {
            _personService.AddPerson(person);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Person person)
        {
            if (id != person.Id)
            {
                return BadRequest();
            }
            _personService.UpdatePerson(person);

            return Ok();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _personService.DeletePerson(id);
        }
    }
}
