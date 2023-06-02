namespace PosApi.Models;

public class InvoiceDetails
{
    public int? Id { get; set; }
    public int? ProductId { get; set; }
    public int? Price { get; set; }
    public int? Quantity { get; set; }
    public int? InvoiceId { get; set; }
    public Invoice Invoice { get; set; }
    
}