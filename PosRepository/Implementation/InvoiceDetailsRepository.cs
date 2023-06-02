using Microsoft.EntityFrameworkCore;
using PosApi.DataContext;
using PosModel.ViewModels;
using PosRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosRepository.Implementation
{
    public class InvoiceDetailsRepository : IInvoiceDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public InvoiceDetailsRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<ICollection<GetInvoiceDetailsVM>> GetInvoiceDetails(int id)
        {
            var invoiceDetails = new List<GetInvoiceDetailsVM>();
            try
            {
                invoiceDetails = await _db.InvoiceDetails.Where(i => i.InvoiceId == id)
                .Include(i => i.Invoice)
                .Select(i => new GetInvoiceDetailsVM
                {
                    CustomerName = i.Invoice.CustomerName,
                    CustomerPhone = i.Invoice.CustomerPhone,
                    Price = i.Price,
                    ProductId = i.ProductId,
                    Quantity = i.Quantity,
                }).ToListAsync();
            }
            catch (Exception ex)
            {
                invoiceDetails = null;
            }
            return invoiceDetails;
        }
    }
}
