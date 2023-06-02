using PosModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosRepository.Contracts
{
    public interface IInvoiceDetailsRepository
    {
        Task<ICollection<GetInvoiceDetailsVM>> GetInvoiceDetails(int id);
    }
}
