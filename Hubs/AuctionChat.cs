using Microsoft.AspNetCore.SignalR;

namespace Auction.Hubs
{
    public class AuctionChat : Hub
    {
        public async Task SendMessage(string user, string message)
        {

            await Clients.All.SendAsync("RecieveMessage", user, message);
        }
    }
}

