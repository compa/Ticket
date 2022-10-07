namespace TicketRepository;

public class TicketRepository : ITicketRepository
{
   public ITicket Tickets { get; set; }
}

public interface ITicket
{
    public List<dynamic> Tickets ()
    {
        return new List<dynamic>();
    }
}