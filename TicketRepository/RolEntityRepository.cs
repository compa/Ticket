using TicketDb;
namespace TicketRepository;

public class RolEntityRepository : RepositoryEntity<Rol>,  IRolEntityRepository
{
    public RolEntityRepository(TicketContext db) : base (db)
    {

    }
}