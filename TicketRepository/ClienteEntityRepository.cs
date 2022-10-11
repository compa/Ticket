using TicketDb;

namespace TicketRepository;
public class ClienteEntityRepository : RepositoryEntity<Cliente>, IClienteEntityRepository
{
    public ClienteEntityRepository(TicketContext db) : base(db)
    {

    }
}