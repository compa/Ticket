using System.ComponentModel.DataAnnotations.Schema;

namespace TicketDb;
public class TicketDetalle 
{
    public long Id { get; set; }
    public DateTime fechaInicio { get; set; }
    public DateTime fechaFinal { get; set; }
    public string descripcionProblema { get; set; }
    public string descripcionSolucion { get; set; }
    public int UsuarioId { get; set; }
    public int AsuntoId { get; set; }
    public int StatusId { get; set; }

    [ForeignKey("TicketDetalle")]
    public int? super { get; set; }
    public Usuario Usuario { get; set; }
    public Asunto Asunto { get; set; }
    public Status Status { get; set; }
    public TicketDetalle TicketDetalles { get; set; }
}