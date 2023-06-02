namespace PosApi.Models;

public class Invoice
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public string CustomerPhone { get; set; }
    public ICollection<InvoiceDetails>? InvoiceDetails { get; set; }
}