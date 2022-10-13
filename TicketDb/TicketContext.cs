namespace TicketDb;

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
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*
        modelBuilder.C
        modelBuilder.Entity<TicketDetalle>()
            .HasRequired(c => c.TicketDetalles)
            .WithMany()
            .WillCascadeOnDelete(false);
            */
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=ACONTABLE14\\SQLSIGMAVER;Initial Catalog=Ticket;User Id=sa;Password=123456papichulo;MultipleActiveResultSets=True;",
            b=> b.MigrationsAssembly("TicketWebApi")
        );
        
    }

    public DbSet<TipoCliente> TipoClientes { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<MedioContacto> MedioContactos { get; set; }
    public DbSet<Ejercicio> Ejercicios { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Asunto> Asuntos { get; set; }
    public DbSet<Rol> Rol { get; set; }
    public DbSet<Status> Status { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketDetalle> TicketDetalles { get; set; }
}