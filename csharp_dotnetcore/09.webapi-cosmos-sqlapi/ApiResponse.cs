using System.Net;

namespace _09.webapi_cosmos_sqlapi
{
    public class ApiResponse
    {
        public HttpStatusCode HttpCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
