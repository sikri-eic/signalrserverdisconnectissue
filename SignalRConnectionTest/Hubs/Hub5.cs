using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRConnectionTest.Hubs
{
    public class Hub5 : Hub
    {
        public async Task Subscribe(int someId)
        {
            var groupName = $"{nameof(Hub5)}__{someId}";

            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task Unsubscribe(int someId)
        {
            var groupName = $"{nameof(Hub5)}__{someId}";

            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        }
    }
}
