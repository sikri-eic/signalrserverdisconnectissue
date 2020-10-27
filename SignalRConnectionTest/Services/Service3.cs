using Microsoft.AspNetCore.SignalR;
using SignalRConnectionTest.Hubs;
using System.Threading.Tasks;

namespace SignalRConnectionTest.Services
{
    public class Service3 : ServiceBase<Hub3>
    {
        public Service3(IHubContext<Hub3> hubContext) : base(hubContext)
        { }

        public override async Task NotifyClientsAsync()
        {
            var someId = 1;
            var groupName = $"{nameof(Hub3)}__{someId}";
            await HubContext.Clients.Group(groupName).SendAsync("SomethingHappened", someId);
        }
    }
}
