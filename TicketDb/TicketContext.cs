namespace TicketDb;

using TicketRepository;
using Microsoft.EntityFrameworkCore;

public class TicketContext : DbContext 
{
    private string _connectionString;
    public TicketContext(DbContextOptions<TicketContext> options) : base (options)
    {   

    }

    public TicketContext(String connectionString)
    {
        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        /*optionsBuilder.UseSqlServer(
            "Data Source=ACONTABLE14\\SQLSIGMAVER;Initial Catalog=Ticket;User Id=sa;Password=123456papichulo;MultipleActiveResultSets=True;",
            b=> b.MigrationsAssembly("TicketWebApi")
        );*/
    }

    public DbSet<TipoMunicipio> TipoMunicipios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
}