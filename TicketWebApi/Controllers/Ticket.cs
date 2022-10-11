using Microsoft.AspNetCore.Mvc;
using TicketDb;
namespace TicketWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TicketController : ControllerBase
{
    private TicketContext _tc;
    public TicketController(TicketContext tc)
    {
        _tc = tc;
    }

    [HttpGet(Name = "Getf")]
    public TipoCliente Get()
    {
        return _tc.TipoClientes.FirstOrDefault();  
    }
}
