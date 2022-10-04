namespace TicketDb;
public class Cliente 
{
    public int Id { get; set; }
    public string clave { get; set; }
    public int TipoMunicipioId { get; set; }
    public TipoMunicipio TipoMunicipio { get; set;}
}