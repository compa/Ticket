using TicketDb;

namespace TicketRepository;

public class UsuarioEntityRepository : RepositoryEntity<Usuario>, IUsuarioEntityRepository
{
    public UsuarioEntityRepository(TicketContext db) : base (db)
    {        
        
    }
}