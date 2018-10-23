﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        /// <summary>
        /// Method Get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetV3()
        {
            return new string[] {"value3", "value3"};
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetV2()
        {
            return new string[] { "value3", "value4" };

        }

        // GET api/values/5
        /// <summary>
        /// Method Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns>id Value</returns>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
        /// <summary>
        /// Method Post
        /// </summary>
        /// <param name="value"></param>
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        
    }
}
