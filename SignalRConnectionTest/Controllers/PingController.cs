using Microsoft.AspNetCore.Mvc;
using SignalRConnectionTest.Services;
using System.Threading.Tasks;

namespace SignalRConnectionTest.Controllers
{
    [Route("ping")]
    public class PingController : ControllerBase
    {
        public PingController(Service1 service1, Service2 service2, Service3 service3)
        {
            Service1 = service1;
            Service2 = service2;
            Service3 = service3;
        }

        public Service1 Service1 { get; }
        public Service2 Service2 { get; }
        public Service3 Service3 { get; }

        [HttpGet]
        public async Task<string> Get()
        {
            await Service1.NotifyClientsAsync();
            await Service2.NotifyClientsAsync();
            await Service3.NotifyClientsAsync();
            return "pong";
        }
    }
}
