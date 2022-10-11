using System.ComponentModel.DataAnnotations.Schema;
namespace TicketDb;
public class Rol
{ 
    public int Id { get; set; }
    public string clave { get; set; }
    public string nombre { get; set; }
}