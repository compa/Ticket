using TicketDb;

namespace TicketRepository;
public class ClienteRepository : IClienteRepository
{
    private TicketContext _tc;
    public ClienteRepository(TicketContext tc)
    {
        _tc = tc;
    }

    public List<Cliente> Get()
    {
        return _tc.Clientes.ToList();
    }

}

public interface IClienteRepository
{
    public List<Cliente> Get();
}