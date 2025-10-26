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
        public ActionResult<List<Person>> GetAll()
        {
            var people = _personService.GetPeople();
            return Ok(people);
        }

        [HttpGet("{id}")]
        public ActionResult<Person> Get(string id)
        {
            var person = _personService.GetPersonById(id);

            if (person is null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            var existingPerson = _personService.GetPersonById(person.Id);

            if (existingPerson is not null)
            {
                return Conflict();
            }

            _personService.AddPerson(person);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Person person)
        {
            if (id != person.Id)
            {
                return BadRequest();
            }

            var oldPerson = _personService.GetPersonById(id);

            if (oldPerson is null)
            {
                return NotFound();
            }

            _personService.UpdatePerson(person);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var existingPerson = _personService.GetPersonById(id);

            if (existingPerson is null)
            {
                return NotFound();
            }

            _personService.DeletePerson(id);

            return Ok();
        }
    }
}
