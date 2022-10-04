namespace TicketDb;
public class Ticket 
{
    public long Id { get; set; }
    public DateTime fecha { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
}