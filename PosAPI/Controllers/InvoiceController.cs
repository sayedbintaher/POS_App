using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PosApi.DataContext;
using PosApi.Models;
using PosApi.ViewModels;
using PosAPI.ViewModels;
using PosService.Contracts;

namespace PosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        public async Task<ActionResult> AddInvoiceWithMultipleDetails(InvoiceVM invoice)
        {
            await _invoiceService.AddInvoiceWithMultipleDetails(invoice);
            return Ok();
        }

        [HttpPost("SingleInvoice")]
        public async Task<ActionResult> AddInvoiceWithSingleDetails(SingleInvoiceVM model)
        {
            await _invoiceService.AddInvoiceWithSingleDetails(model);
            return Ok();
        }
        [HttpGet("GetAllInvoice")]
        public async Task<ActionResult<ICollection<Invoice>>> GetAllInvoice()
        {
            var res = await _invoiceService.GetAllInvoices();
            if(res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }
    }
}
