using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}
