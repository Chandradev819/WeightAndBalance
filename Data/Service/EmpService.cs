using System.Net.Http;

namespace WeightAndBalance.Service
{
    public class EmpService:IEmp
    {
        private readonly HttpClient httpClient;
        public EmpService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public string SayHello()
        {
            return "Hello";
        }
    }
}
