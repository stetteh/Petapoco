using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace Petapoco
{
    [TableName("SalesMade")]
    [PrimaryKey("SalesId")]
    public class SalesMade
    {
        public int SalesId { get; set; }
        public string Name { get; set; }
        public DateTime SalesDate { get; set; }
        public int PreTaxAmount { get; set; }
    }
}
