using Microsoft.AspNetCore.Mvc;
using static PruebaNetFrontEnd.Utility.SD;

namespace PruebaNetFrontEnd.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
    }
}
