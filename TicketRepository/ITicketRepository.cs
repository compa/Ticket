using System.Linq.Expressions;

namespace TicketRepository;

public interface ITicketRepository
{
    public ITipoClienteEntityRepository TipoClientes { get; }
    public IRolEntityRepository Roles { get; }
    public IAsuntoEntityRepository Asuntos { get; }
    public IDepartamentoEntityRepository Departamentos { get; }
    public IEjercicioEntityRepository Ejercicios { get; }
    public IMedioContactoEntityRepository MedioContactos { get; }
    public IClienteEntityRepository Clientes { get; }
    public IStatusEntityRepository Status { get; }
    public IUsuarioEntityRepository Usuario { get; }
    public ITicketEntityRepository Tickets { get; }
    public ITicketDetalleEntityRepository TicketDetalles { get; }
    public void Save();
}

