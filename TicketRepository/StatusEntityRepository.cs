using TicketDb;
namespace TicketRepository;

public class StatusEntityRepository : RepositoryEntity<Status>,  IStatusEntityRepository
{
    public StatusEntityRepository(TicketContext db) : base (db)
    {

    }
}