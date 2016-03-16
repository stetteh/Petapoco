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

            //
            SalesPeople newSalesPeople = new SalesPeople();
            SalesPeople newSalesPeople2 = new SalesPeople();

            newSalesPeople.Name = "Seth Quaye";
            newSalesPeople2.Name = "Deacon";

            db.Insert(newSalesPeople);
            db.Insert(newSalesPeople2);
            //Assert.True(newSalesPeople.PeopleId != 0);

        }
    }
}
