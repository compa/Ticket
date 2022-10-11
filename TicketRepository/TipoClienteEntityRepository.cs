using TicketDb;

namespace TicketRepository;

public class TipoClienteEntityRepository : RepositoryEntity<TipoCliente>, ITipoClienteEntityRepository
{
    public TipoClienteEntityRepository(TicketContext db) : base (db)
    {        
        
    }
}