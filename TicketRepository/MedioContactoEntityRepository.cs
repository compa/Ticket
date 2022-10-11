using TicketDb;
namespace TicketRepository;

public class MedioContactoEntityRepository : RepositoryEntity<MedioContacto>,  IMedioContactoEntityRepository
{
    public MedioContactoEntityRepository(TicketContext db) : base (db)
    {

    }
}