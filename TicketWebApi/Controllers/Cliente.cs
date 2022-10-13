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

    [HttpPost(Name= "Post")]
    public List<Cliente> Post()
    {
        Random rnd = new Random();
        const int DEFAULT_TIPO_CLIENTE = 1;

        var cliente1 = _db.Clientes.Create(new Cliente(){
            clave = rnd.Next(10000, 100000).ToString(),
            TipoClienteId = DEFAULT_TIPO_CLIENTE
        });

        var cliente2 = _db.Clientes.Create(new Cliente(){
            clave = rnd.Next(10000, 100000).ToString(),
            TipoClienteId = DEFAULT_TIPO_CLIENTE
        });
        
        _db.Save();
        return new List<Cliente>(){
            cliente1,
            cliente2
        };  
    }

}
