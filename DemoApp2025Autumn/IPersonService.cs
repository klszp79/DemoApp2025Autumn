namespace DemoApp2025Autumn.App
{
    public interface IPersonService
    {
        Person GetPersonById(string id);
        List<Person> GetPeople();
        void AddPerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(string id);
    }
}
