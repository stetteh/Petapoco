using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petapoco
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new PetaPoco.Database("dbstring");

            //SalesPeople newSalesPeople2 = new SalesPeople();
            //db.Insert(newSalesPeople);

            List<SalesPeople> salesperson = new List<SalesPeople>();
            salesperson.Add(new SalesPeople("Deacon"));
            salesperson.Add(new SalesPeople("Edan"));
            salesperson.Add(new SalesPeople("Yardley"));
            salesperson.Add(new SalesPeople("Farrah"));
            salesperson.Add(new SalesPeople("Jessamine"));
            salesperson.Add(new SalesPeople("Isabelle"));
            salesperson.Add(new SalesPeople("Judah"));

            foreach (var sp in salesperson)
            {
                db.Insert(sp);
            }

            
          

        }
    }
}
