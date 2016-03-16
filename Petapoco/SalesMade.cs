using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petapoco
{
    public class SalesMade
    {
        public int SalesId { get; set; }
        public string Name { get; set; }
        public DateTime SalesDate { get; set; }
        public int PreTaxAmount { get; set; }
    }
}
