using Microsoft.AspNetCore.Mvc;

namespace DemoApp2025Autumn.App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService1;
        private readonly ITestService _testService2;
        public TestController(ITestService testService1, ITestService testService2)
        {
            _testService1 = testService1;
            _testService2 = testService2;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Guid1 = _testService1.GetGuid(),
                Guid2 = _testService2.GetGuid()
            });
        }

    }
}
