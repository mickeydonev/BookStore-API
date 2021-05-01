using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_API.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore_API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILoggerService _logger;

        /// <summary>
        /// 
        /// </summary>
        public HomeController(ILoggerService logger)
        {
            _logger = logger;

        }
        /// <summary>
        /// This is a GET controller with no parameter
        /// </summary>
        // GET: api/<HomeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Default Get method was accessed!");
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 
        /// </summary>
        // GET api/<HomeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// 
        /// </summary>
        // POST api/<HomeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogError("this is an Error!");
        }

        /// <summary>
        /// 
        /// </summary>
        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
