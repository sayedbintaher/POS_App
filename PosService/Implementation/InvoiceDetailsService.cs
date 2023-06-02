using PosModel.ViewModels;
using PosRepository.Contracts;
using PosService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosService.Implementation
{
    public class InvoiceDetailsService : IInvoiceDetailsService
    {
        private readonly IInvoiceDetailsRepository _invoiceDetailsRepo;

        public InvoiceDetailsService(IInvoiceDetailsRepository invoiceDetailsRepo)
        {
            _invoiceDetailsRepo = invoiceDetailsRepo;
        }
        public Task<ICollection<GetInvoiceDetailsVM>> GetInvoiceDetails(int id)
        {
            return _invoiceDetailsRepo.GetInvoiceDetails(id);
        }
    }
}
