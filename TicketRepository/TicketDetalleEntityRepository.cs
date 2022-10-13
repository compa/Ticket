using TicketDb;
namespace TicketRepository;

public class TicketDetalleEntityRepository : RepositoryEntity<TicketDetalle>,  ITicketDetalleEntityRepository
{
    public TicketDetalleEntityRepository(TicketContext db) : base (db)
    {

    }
}