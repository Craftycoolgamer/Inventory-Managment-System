using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System
{
    public class InHouse : Part
    {
        private int machineID;
        public int MachineID { get; set; }

        public InHouse() { }

        public InHouse(int id, string name, int instock, string price, int max, int min, int machID)
        {
            PartID = id;
            Name = name;
            InStock = instock;
            Price = price;
            Max = max;
            Min = min;
            MachineID = machID;

        }

    }
}
