using System.ComponentModel.DataAnnotations.Schema;
namespace TicketDb;
public class Usuario
{ 
    public int Id { get; set; }
    public string name { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public int RolId { get; set; }
    public Rol Rol { get; set;}
}