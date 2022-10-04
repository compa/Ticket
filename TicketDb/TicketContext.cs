namespace TicketDb;
using TicketRepository;


using Microsoft.EntityFrameworkCore;
public class TicketContext : DbContext, ITicketRepository 
{
    public TicketContext(DbContextOptions<TicketContext> options) : base (options)
    {   
    }

    public DbSet<TipoMunicipio> TipoMunicipios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
}