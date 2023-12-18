using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHint.Model.Entity
{
    public class CustomerInfo
    {
        public int CustomerInfoId { get; set; }
        public string CustomerDisclaimer { get; set; }
        public string CustomerGender { get; set; }
        public DateTime CustomerDateOfBirth { get; set; }
        public bool CustomerBlocked { get; set; }
        public string CustomerPassword { get; set; }
        public ICollection<CustomerBase> Customers { get; set; }

    }
}
