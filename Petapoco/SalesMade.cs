using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace Petapoco
{
    [TableName("SalesMade")]
    [PrimaryKey("Id")]
    public class SalesMade
    {
        public SalesMade(string name, DateTime dateTime, int pretax)
        {
            this.Name = name;
            this.SalesDate = dateTime;
            this.PreTaxAmount = pretax;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime SalesDate { get; set; }
        public int PreTaxAmount { get; set; }
    }
}
