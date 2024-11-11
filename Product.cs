using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory_Managment_System
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        private int productID;
        public string name;
        public int instock;
        public decimal price;
        public int max;
        public int min;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Instock { get; set; }
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
        public int Max { get; set; }
        public int Min { get; set; }

        public Product(int id, string n, int stock, string p, int mx, int mn)
        {
            ProductID = id;
            Name = n;
            Instock = stock;
            Price = p;
            Max = mx;
            Min = mn;
        }
        public Product() { }



        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            bool worked = false;
            foreach (Part part in AssociatedParts)
            {
                if (partID == part.PartID)
                {
                    AssociatedParts.Remove(part);
                    return true;
                }
                else
                {
                    MessageBox.Show("Error: Failed to remove Associated Parts");
                    return false;
                }
            }
            return worked;

        }

        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            InHouse empty = new InHouse();
            return empty;
        }


    }
}
