using Microsoft.AspNetCore.Mvc;
using Xylox.News.Entities;
using Xylox.News.Storage;

namespace Xylox.News.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly IDataStore _dataStore;
        public NewsController(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        [HttpGet]
        public IActionResult List()
        {
            var result = _dataStore.Get();
            return new JsonResult(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody]XyloxNews item)
        {
            _dataStore.Add(item);
            return Ok($"Item: {item.Id}, has been added.");
        }
    }
}
