using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OcrService.OcrServiceLogic
{
    public class GoogleResponse
    {
        public List<TextAnnotation> Responses { get; set; }
    }

    public class TextAnnotation
    {
        public List<SingleAnnotation> TextAnnotations { get; set; }
    }

    public class SingleAnnotation
    {
        public string Locale { get; set; }
        public string Description { get; set; }
        public object BoundingPoly { get; set; } // I don't use this prop for now so leaving it as a general object
    }
}
