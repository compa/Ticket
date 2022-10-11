using TicketDb;
namespace TicketRepository;

public class AsuntoEntityRepository : RepositoryEntity<Asunto>,  IAsuntoEntityRepository
{
    public AsuntoEntityRepository(TicketContext db) : base (db)
    {

    }
}