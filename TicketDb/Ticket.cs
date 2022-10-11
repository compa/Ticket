namespace TicketDb;
public class Ticket 
{
    public long Id { get; set; }
    public DateTime fecha { get; set; }
    public int ClienteId { get; set; }
    public int AsuntoId { get; set; }
    public int MedioContactoId { get; set; }
    public int DepartamentoId { get; set; }
    public int EjercicioId { get; set; }
    public Asunto Asunto { get; set; }
    public MedioContacto MedioContacto { get; set; }
    public Cliente Cliente { get; set; }
    public Departamento Departamento { get; set; }
    public Ejercicio Ejercicio { get; set; }
}