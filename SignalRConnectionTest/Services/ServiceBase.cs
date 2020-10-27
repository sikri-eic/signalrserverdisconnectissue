using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace SignalRConnectionTest.Services
{
    public abstract class ServiceBase<THub> where THub : Hub
    {
        protected IHubContext<THub> HubContext { get; }

        public ServiceBase(IHubContext<THub> hubContext)
        {
            HubContext = hubContext ?? throw new ArgumentNullException(nameof(hubContext));
        }

        public abstract Task NotifyClientsAsync();
    }
}
