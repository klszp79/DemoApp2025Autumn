
using Microsoft.AspNetCore.Http.HttpResults;

namespace DemoApp2025Autumn.App
{
    public class PersonService : IPersonService
    {
        private readonly List<Person> _people = new List<Person>();
        public PersonService() { }
        public void AddPerson(Person person)
        {
            if (person is not null)
            {
                _people.Add(person);
            }
        }

        public void DeletePerson(int id)
        {
            var person = _people.Find(p => p.Id == id);
            if (person is not null)
            {
                _people.Remove(person);
            }
        }

        public List<Person> GetPeople()
        {
            return _people;
        }

        public Person GetPersonById(int id)
        {
            var person = _people.Find(p => p.Id == id);

            return person ?? new Person();
        }

        public void UpdatePerson(Person person)
        {
            var oldPerson = _people.Find(p => p.Id == person.Id);

            if (oldPerson is not null)
            {
                oldPerson.Name = person.Name;
                oldPerson.EmailAddress = person.EmailAddress;
                oldPerson.Age = person.Age;
                oldPerson.Birthday = person.Birthday;
            }
        }
    }
}
