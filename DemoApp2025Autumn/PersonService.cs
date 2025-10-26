
using Microsoft.AspNetCore.Http.HttpResults;

namespace DemoApp2025Autumn.App
{
    public class PersonService : IPersonService
    {
        private readonly List<Person> _people = new List<Person>();
        public PersonService() 
        {
            _people = [];
        }
        public void AddPerson(Person person)
        {
            if (person is not null)
            {
                _people.Add(person);
            }
        }

        public void DeletePerson(string id)
        {
            _people.RemoveAll(x => x.Id == id);
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
        }
    }
}
