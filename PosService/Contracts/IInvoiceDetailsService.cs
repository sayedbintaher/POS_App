using PosModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosService.Contracts
{
    public interface IInvoiceDetailsService
    {
        Task<ICollection<GetInvoiceDetailsVM>> GetInvoiceDetails(int id);
    }
}
