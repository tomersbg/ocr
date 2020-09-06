using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OcrService.OcrServiceLogic
{
    public interface IOcrService
    {
        public OcrResult GetOcrResult(IFormFile file);
    }
}
