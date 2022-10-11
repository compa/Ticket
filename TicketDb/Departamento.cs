using System.ComponentModel.DataAnnotations.Schema;
namespace TicketDb;
public class Departamento 
{
    public int Id { get; set; }
    public string clave { get; set; }
    public string nombre { get; set; }
    public string tipo { get; set; }

    [ForeignKey("Departamento")]
    public string super { get; set; }
    public List<Departamento> Departamentos { get; set; }    
}