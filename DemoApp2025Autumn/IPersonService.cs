namespace DemoApp2025Autumn.App
{
    public interface IPersonService
    {
        Person GetPersonById(int id);
        List<Person> GetPeople();
        void AddPerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(int id);
    }
}
