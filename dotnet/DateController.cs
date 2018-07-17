using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace date
{
    [Route("api/date")]
    public class DateCheckController : Controller
    {
        /// <summary>
        /// Endpoint used for health checks
        /// </summary>
        /// <returns>Returns the name of the controller and the time of the call.</returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {Environment.MachineName.ToString() + " - " + DateTime.UtcNow.ToString()};
          
        
            }
        



    }
}
