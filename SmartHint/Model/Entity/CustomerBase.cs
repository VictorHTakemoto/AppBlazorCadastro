using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SmartHint.Model.Entity
{
    public class CustomerBase
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(150)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(150)]
        public string CustomerEmail { get; set; }
        public int CustomerPhone { get; set; }
        public DateTime CustomerAccountData { get; set; }
        public string CustomerType { get; set; }

        public int CustomerDocumentId { get; set; }
        public CustomerDocument CustomerDocument { get; set; }

        public int CustomerInfoId {  get; set; }
        public CustomerInfo CustomerInfo { get; set;}

    }
}
