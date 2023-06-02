using PosApi.Models;
using PosApi.ViewModels;
using PosAPI.ViewModels;

namespace PosService.Contracts
{
    public interface IInvoiceService
    {
        Task AddInvoiceWithMultipleDetails(InvoiceVM invoice);
        Task AddInvoiceWithSingleDetails(SingleInvoiceVM model);
        Task<ICollection<Invoice>> GetAllInvoices();
    }
}
