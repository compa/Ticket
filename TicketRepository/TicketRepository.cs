using TicketDb;

namespace TicketRepository;
public class TicketRepository : ITicketRepository
{
   private TicketContext _db;
   public TicketRepository(TicketContext db)
   {
      _db = db;
   }
   public ITipoClienteEntityRepository TipoClientes 
   { 
      get 
      {
         return new TipoClienteEntityRepository(_db);
      } 
   }

   public IRolEntityRepository Roles 
   { 
      get 
      {
         return new RolEntityRepository(_db);
      }
   }
   public IAsuntoEntityRepository Asuntos 
   { 
      get
      {
         return new AsuntoEntityRepository(_db);
      }
   }
   public IDepartamentoEntityRepository Departamentos
   { 
      get
      {
         return new DepartamentoEntityRepository(_db);
      }
   }
      
   public IEjercicioEntityRepository Ejercicios
   { 
      get
      {
         return new EjercicioEntityRepository(_db);
      }
   }
   public IMedioContactoEntityRepository MedioContactos
   { 
      get
      {
         return new MedioContactoEntityRepository(_db);
      }
   }
   public IClienteEntityRepository Clientes
   { 
      get
      {
         return new ClienteEntityRepository(_db); 
      }
   }
   public IStatusEntityRepository Status 
   { 
      get
      {
         return new StatusEntityRepository(_db);
      }
   }
   public ITipoClienteEntityRepository TipoCliente
   { 
      get
      {
         return new TipoClienteEntityRepository(_db);
      }
   }
   public IUsuarioEntityRepository Usuario
   { 
      get
      {
         return new UsuarioEntityRepository(_db);
      }
   }
   public ITicketEntityRepository Tickets 
   { 
      get
      {
         return null;
      }
   }
   public ITicketDetalleEntityRepository TicketDetalles
   { 
      get
      {
         return null;
      }
   }

}