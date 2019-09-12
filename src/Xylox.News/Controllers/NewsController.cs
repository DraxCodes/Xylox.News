using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
            var test = result.CastTo<XyloxNews>();

            return new JsonResult(test);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody]XyloxNews item)
        {
            _dataStore.Add(item);
            return Ok($"Item: {item.Id}, has been added.");
        }
    }
}
