namespace DemoApp2025Autumn.App
{
    public class TestService : ITestService
    {
        private readonly string _guid;
        public TestService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
