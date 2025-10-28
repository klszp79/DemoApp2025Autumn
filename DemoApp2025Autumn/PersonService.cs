
using Microsoft.AspNetCore.Http.HttpResults;

namespace DemoApp2025Autumn.App
{
    public class PersonService : IPersonService
    {
        private readonly List<Person> _people = new List<Person>();
        private readonly ILogger<PersonService> _logger;
        public PersonService(ILogger<PersonService> logger) 
        {
            _people = [];
            _logger = logger;
        }
        public void AddPerson(Person person)
        {
            if (person is not null)
            {
                _people.Add(person);
            }

            _logger.LogInformation("Person added: {@Person}", person);
        }

        public void DeletePerson(string id)
        {
            _people.RemoveAll(x => x.Id == id);

            _logger.LogInformation("Person deleted");
        }

        public List<Person> GetPeople()
        {
            return _people;
        }

        public Person GetPersonById(string id)
        {
            var person = _people.Find(p => p.Id == id);

            return person;
        }

        public void UpdatePerson(Person person)
        {
            var oldPerson = GetPersonById(person.Id);

            if (oldPerson is not null)
            {
                oldPerson.Name = person.Name;
                oldPerson.EmailAddress = person.EmailAddress;
                oldPerson.Birthday = person.Birthday;
            }

            _logger.LogInformation("Person updated");
        }
    }
}
