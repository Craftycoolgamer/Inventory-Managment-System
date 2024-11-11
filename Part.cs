using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        public int PartID { get { return partID; } set { partID = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Price
        {
            get { return price.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    price = decimal.Parse(value.Substring(1));
                }
                else
                {
                    price = decimal.Parse(value);
                }
            }
        }
        public int InStock { get { return inStock; } set { inStock = value; } }
        public int Min { get { return min; } set { min = value; } }
        public int Max { get { return max; } set { max = value; } }
    }
}
