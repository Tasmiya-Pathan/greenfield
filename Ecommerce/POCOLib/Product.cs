using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POCOLib
{
    [Serializable]                 // Must write to instruct to CLR , compiler that this is serializable
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }


    }
}