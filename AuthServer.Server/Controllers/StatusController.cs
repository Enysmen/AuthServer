using System.Net;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic; // optional if your project already has

namespace AuthServer.Server.Controllers
{
    [Route("api/status")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        
        string statusProcessing = "running"; 
        string serviceName = "AuthServer"; 

        [HttpGet]
        public IActionResult GetStatus()
        {
            return new JsonResult(new
            {
                status = statusProcessing,
                service = serviceName
            });
        }

    }
}
