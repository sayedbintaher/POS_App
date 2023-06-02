using Microsoft.EntityFrameworkCore;
using PosApi.DataContext;
using PosApi.Models;
using PosApi.ViewModels;
using PosAPI.ViewModels;
using PosRepository.Contracts;
using PosService.Contracts;
using System.Runtime.CompilerServices;

namespace PosService.Implementation
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepo;

        public InvoiceService(IInvoiceRepository invoiceRepo)
        {
            _invoiceRepo = invoiceRepo;
        }

        public async Task AddInvoiceWithMultipleDetails(InvoiceVM invoice)
        {
             await _invoiceRepo.AddInvoiceWithMultipleDetails(invoice);
        }

        public async Task AddInvoiceWithSingleDetails(SingleInvoiceVM model)
        {
            await _invoiceRepo.AddInvoiceWithSingleDetails(model);
        }

        public async Task<ICollection<Invoice>> GetAllInvoices()
        {
            return await _invoiceRepo.GetAllInvoices();
        }
    }
}
