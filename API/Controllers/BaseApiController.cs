using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api/activities should hit activities endpoint
    public class BaseApiController : ControllerBase
    {
        
    }
}