namespace TicketDb;
public class Cliente 
{
    public int Id { get; set; }
    public string clave { get; set; }
    public int TipoClienteId { get; set; }
    public TipoCliente TipoCliente { get; set;}
}