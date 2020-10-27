using Microsoft.AspNetCore.SignalR;
using SignalRConnectionTest.Hubs;
using System.Threading.Tasks;

namespace SignalRConnectionTest.Services
{
    public class Service1 : ServiceBase<Hub1>
    {
        public Service1(IHubContext<Hub1> hubContext) : base(hubContext)
        { }

        public override async Task NotifyClientsAsync()
        {
            var someId = 1;
            var groupName = $"{nameof(Hub1)}__{someId}";
            await HubContext.Clients.Group(groupName).SendAsync("SomethingHappened", someId);
        }
    }
}
