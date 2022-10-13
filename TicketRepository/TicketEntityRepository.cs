using TicketDb;
namespace TicketRepository;

public class TicketEntityRepository : RepositoryEntity<Ticket>,  ITicketEntityRepository
{
    public TicketEntityRepository(TicketContext db) : base (db)
    {
    
    }
}