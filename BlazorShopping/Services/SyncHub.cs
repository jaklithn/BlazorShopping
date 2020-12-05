using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace BlazorShopping.Services
{
    /// <summary>
    /// This hub is currently not used.
    /// The idea is to extend the app functionality by providing live updates to the UI when other users update the shopping content.
    /// </summary>
    public class SyncHub : Hub
    {
        public async Task SyncPlanning(Guid articleId, float quantity)
        {
            await Clients.Others.SendAsync("SyncPlanning", articleId, quantity);
        }
    }
}
