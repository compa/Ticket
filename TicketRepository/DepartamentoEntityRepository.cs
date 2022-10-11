using TicketDb;
namespace TicketRepository;

public class DepartamentoEntityRepository : RepositoryEntity<Departamento>,  IDepartamentoEntityRepository
{
    public DepartamentoEntityRepository(TicketContext db) : base (db)
    {

    }
}