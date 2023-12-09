using Microsoft.AspNetCore.SignalR;
using ProjetoA2.Controllers;

namespace ProjetoA2.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user)
        {
            // await Clients.All.SendAsync("ReceiveMessage", user);
        }
    }
}
