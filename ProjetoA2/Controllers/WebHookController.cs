using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Mvc;
using ProjetoA2.Models;
using ProjetoA2.Hubs;

namespace ProjetoA2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebHookController : ControllerBase
    {
        private readonly IHubContext<ChatHub> _hubContext;

        public WebHookController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public async void receberDadosWebHook(PagamentoPix pagamentoPix)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", pagamentoPix.pix[0].txid, pagamentoPix.pix[0].valor);
        }

        [HttpGet]
        public async void get()
        {
        }
    }
}
