using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHint.Model.Entity
{
    public class CustomerDocument
    {
        public int CustomerDocumentId { get; set; }
        public string CustomerCPF { get; set; }
        public string CustomerCNPJ { get; set; }
        public string CutomerIE { get; set; }
        public ICollection<CustomerBase> Customers { get; set; }

    }
}
