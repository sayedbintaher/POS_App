using Microsoft.EntityFrameworkCore;
using PosApi.DataContext;
using PosApi.Models;
using PosApi.ViewModels;
using PosAPI.ViewModels;
using PosRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosRepository.Implementation
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly ApplicationDbContext _db;

        public InvoiceRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task AddInvoiceWithMultipleDetails(InvoiceVM invoice)
        {
            var invoiceModel = new Invoice
            {
                CustomerName = invoice.CustomerName,
                CustomerPhone = invoice.CustomerPhone
            };
            await _db.Invoices.AddAsync(invoiceModel);
            foreach (var item in invoice.InvoiceDetails)
            {
                var invoiceDetailsModel = new InvoiceDetails
                {
                    Price = item.Price,
                    Quantity = item.Quantity,
                    ProductId = item.ProductId,
                    Invoice = invoiceModel
                };
                await _db.InvoiceDetails.AddAsync(invoiceDetailsModel);
            }
            await _db.SaveChangesAsync();
        }

        public async Task AddInvoiceWithSingleDetails(SingleInvoiceVM model)
        {
            var invoice = new Invoice
            {
                CustomerName = model.CustomerName,
                CustomerPhone = model.CustomerPhone,
            };
            await _db.Invoices.AddAsync(invoice);
            var invoiceDetails = new InvoiceDetails
            {
                Price = model.Price,
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                Invoice = invoice
            };
            await _db.InvoiceDetails.AddAsync(invoiceDetails);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<Invoice>> GetAllInvoices()
        {   
            var invoiceList = new List<Invoice>();
            try
            {
                invoiceList = await _db.Invoices.ToListAsync();

            }catch(Exception ex)
            {
                return invoiceList;
            }
            return invoiceList;
        }
    }
}
