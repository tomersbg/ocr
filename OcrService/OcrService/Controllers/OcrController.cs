using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OcrService.OcrServiceLogic;

namespace OcrService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OcrController : ControllerBase
    {
        private readonly IOcrService _service;

        public OcrController(IOcrService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("upload")]
        public OcrResult Post(IFormFile file)
        {
            return _service.GetOcrResult(file);
        }
    }
}
