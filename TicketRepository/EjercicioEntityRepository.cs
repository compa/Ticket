using TicketDb;
namespace TicketRepository;

public class EjercicioEntityRepository : RepositoryEntity<Ejercicio>,  IEjercicioEntityRepository
{
    public EjercicioEntityRepository(TicketContext db) : base (db)
    {

    }
}