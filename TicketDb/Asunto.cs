using System.ComponentModel.DataAnnotations.Schema;
namespace TicketDb;
public class Asunto 
{
    public int Id { get; set; }
    public string clave { get; set; }
    public string nombre { get; set; }
    public string tipo { get; set; }
    public bool seleccionable { get; set; }

    [ForeignKey("Asunto")]
    public string super { get; set; }
    public List<Asunto> Asuntos { get; set; }    
}