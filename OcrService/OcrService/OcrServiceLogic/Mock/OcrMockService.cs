using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OcrService.OcrServiceLogic.Mock
{
    public class OcrMockService : IOcrService
    {
        public OcrResult GetOcrResult(IFormFile file)
        {
            // Here we should go to Google, instead we read from the mock json
            var str = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "response.json"));
            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<GoogleResponse>(str);
            double doubleRes = 0;
            // This is a dummy logic, takes all numbers and adds them
            response.Responses.ForEach(x => {
                x.TextAnnotations.ForEach(x =>
                {
                    if (double.TryParse(x.Description, out var descNumber))
                        doubleRes += descNumber;
                });
            });
            return new OcrResult { TotalAmount = new Random().NextDouble() };
        }
    }
}
