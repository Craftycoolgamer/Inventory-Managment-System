using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory_Managment_System
{
    public class Outsourced : Part
    {
        private string companyName;
        public string CompanyName { get; set; }

        public Outsourced(int id, string name, int instock, string price, int max, int min, string companyName)
        {
            PartID = id;
            Name = name;
            InStock = instock;
            Price = price;
            Max = max;
            Min = min;
            CompanyName = companyName;

        }
    }
}
