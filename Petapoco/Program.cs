using System;
using System.CodeDom;
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

            List<SalesMade> salesmade = new List<SalesMade>()
            {
                new SalesMade("Deacon", new DateTime(2015, 10, 15), 8852),
                new SalesMade("Edan", new DateTime(2015, 12, 07), 5255),
                new SalesMade("Deacon", new DateTime(2016, 02, 27), 5259),
                new SalesMade("Yardley", new DateTime(2015, 11, 23), 7244),
                new SalesMade("Farrah", new DateTime(2015, 12, 21), 8711),
                new SalesMade("Deacon", new DateTime(2015, 10, 02), 740),
                new SalesMade("Jessamine", new DateTime(2015, 04, 02), 9970),
                new SalesMade("Isabelle", new DateTime(2015, 12, 25), 6009),
                new SalesMade("Judah", new DateTime(2014, 07, 03), 9703)
            };

            foreach (var sm in salesmade)
            {
                db.Insert(sm);
            }

           // var a = db.SingleOrDefault<SalesPeople>("SELECT * FROM SalesPeople");
            //var a = db.SingleOrDefault<SalesPeople>("WHERE PeopleId=@0", 123);
           

            foreach (var s in db.Query<SalesPeople>("select * from SalesPerson"))
            {
                Console.WriteLine(s);
            }
            foreach (var smin in db.Query<SalesMade>("Select min(PreTaxAmount) SalesMade"))
            {
                Console.WriteLine(smin.PreTaxAmount);
            }
            foreach (var smax in db.Query<SalesMade>("Select min(PreTaxAmount) SalesMade"))
            {
                Console.WriteLine(smax.PreTaxAmount);
            }
            // var s = db.Query<SalesPeople>("select * from sales");



                //var getAllCutomers = dotnet.Query<Customer>("SELECT * FROM Customers");

                //Console.WriteLine(s);

                Console.ReadLine();






        }
    }
}
