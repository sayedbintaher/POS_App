using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PosModel.ViewModels;
using PosService.Contracts;

namespace PosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceDetailsController : ControllerBase
    {
        private readonly IInvoiceDetailsService _invoiceDetailsService;

        public InvoiceDetailsController(IInvoiceDetailsService invoiceDetailsService)
        {
            _invoiceDetailsService = invoiceDetailsService;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<GetInvoiceDetailsVM>>> GetInvoiceDetails(int id)
        {
            var res = await _invoiceDetailsService.GetInvoiceDetails(id);
            if(res == null)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
    }
}
