using Microsoft.AspNetCore.Mvc;
using TicketRepository;
using TicketDb;

namespace TicketWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private ITicketRepository _db;
    public ClienteController(ITicketRepository db)
    {
        _db = db;
    }

    [HttpGet(Name = "Get")]
    public List<Cliente> Get()
    {
        return _db.Clientes.List();  
    }
}
