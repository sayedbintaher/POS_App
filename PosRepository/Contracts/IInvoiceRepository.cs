using PosApi.Models;
using PosApi.ViewModels;
using PosAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosRepository.Contracts
{
    public interface IInvoiceRepository
    {
        Task AddInvoiceWithMultipleDetails(InvoiceVM invoice);
        Task AddInvoiceWithSingleDetails(SingleInvoiceVM model);
        Task<ICollection<Invoice>> GetAllInvoices();
    }
}
