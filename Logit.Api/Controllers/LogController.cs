using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logit.Api.DomainModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Logit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        // GET api/log
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Log>> Get()
        {
            return new List<Log>
            {
                new Log {Id = 1, CreatedDate=DateTime.Now, CreatedBy="Eileen", Description ="Server 1 is not working", Status= LogStatus.New}
            };
        }

        // GET api/log/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<Log> Get(int id)
        {
            return new Log { Id = id, CreatedDate = DateTime.Now, CreatedBy = "Eileen", Description = "Server 1 is not working", Status = LogStatus.New };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fetchLogQuery"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        [HttpGet("filter")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<Log>> Get([FromQuery]FetchLogQuery fetchLogQuery)
        {
            return new List<Log>
            {
                new Log { Id = 2, CreatedDate = DateTime.Now, CreatedBy = "Eileen", Description = "Server 1 is not working", Status = LogStatus.New }
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        // POST api/log - Create New
        [HttpPost]
        public void Post([FromBody] Log value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/log/5 - Update
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Log value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/log/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
