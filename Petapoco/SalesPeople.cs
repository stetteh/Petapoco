﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace Petapoco
{
    [TableName("SalesPeople")]
    [PrimaryKey("PeopleId")]
    public class SalesPeople
    {
        
        public SalesPeople(string name)
        {
            this.Name = name;
        }

        public int PeopleId { get; set; }
        public string Name { set; get; }
    }
}
