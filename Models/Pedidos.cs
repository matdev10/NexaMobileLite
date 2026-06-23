namespace NexaMobileLite.Models;

public class Pedido
{
    public int Id { get; set; }
    public string Cliente { get; set; } = "";
    public decimal Total { get; set; }
    public string Estado { get; set; } = "";
    public DateTime Fecha { get; set; }
}