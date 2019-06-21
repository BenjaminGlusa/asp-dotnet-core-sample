using Microsoft.AspNetCore.Mvc;

namespace Sample
{
    
    [Route("api/[controller]")]
    public class DummyController : ControllerBase
    {
        
        [HttpGet]
        public string Index()
        {
            return "All is good.";
        }

        [HttpGet("{id}")]
        public string Id(int id)
        {
            return $"Kekse sind lecker {id.MultiplyByTen()}";
        }

        [HttpPost]
        public string Post([FromBody] string name)
        {
            return $"your name is {name}";
        }
    }
}

internal static class IntExtensions
{
    public static int MultiplyByTen(this int i)
    {
        return i * 10;
    } 
}
   


