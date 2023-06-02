using PosAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosModel.ViewModels
{
    public class GetInvoiceDetailsVM
    {
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public int? ProductId { get; set; }
        public int? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
