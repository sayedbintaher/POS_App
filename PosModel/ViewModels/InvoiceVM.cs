using PosApi.Models;
using PosAPI.ViewModels;

namespace PosApi.ViewModels;

public class InvoiceVM
{
    public string CustomerName { get; set; }
    public string CustomerPhone { get; set; }
    public ICollection<InvoiceDetailsVM> InvoiceDetails { get; set; }

}