using Microsoft.AspNetCore.SignalR;
using SignalRConnectionTest.Hubs;
using System.Threading.Tasks;

namespace SignalRConnectionTest.Services
{
    public class Service2 : ServiceBase<Hub2>
    {
        public Service2(IHubContext<Hub2> hubContext) : base(hubContext)
        { }

        public override async Task NotifyClientsAsync()
        {
            var someId = 1;
            var groupName = $"{nameof(Hub2)}__{someId}";
            await HubContext.Clients.Group(groupName).SendAsync("SomethingHappened", someId);
        }
    }
}
