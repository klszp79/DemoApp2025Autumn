using Microsoft.AspNetCore.Mvc;

namespace DemoApp2025Autumn.App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CounterController : ControllerBase
    {
        private static int _count = 0;

        public CounterController()
        {
        }
        [HttpGet(Name = "GetCounter")]
        public int Get()
        {
            return ++_count;
        }
    }
}
