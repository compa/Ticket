using Microsoft.AspNetCore.Mvc;
using TicketRepository;
using TicketDb;

namespace TicketWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private IClienteRepository _cr;
    public ClienteController(IClienteRepository cr)
    {
        _cr = cr;
    }

    [HttpGet(Name = "Get")]
    public List<Cliente> Get()
    {
        return _cr.Get();  
    }
}
