using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();
        public static Random rand = new Random();

        //Generate Random Number
        public static int GenerateRandomNum(bool part)
        {
            //Generates a random 4 digit ID number Recursively
            int min = 1000;
            int max = 9999;
            int temp = rand.Next(min, max);


            if (part)
            {
                foreach (Part p in Parts)
                {
                    if (p.PartID == temp)
                    {
                        temp = GenerateRandomNum(part);
                    }
                }
                
            }
            else
            {
                foreach (Product p in Products)
                {
                    if (p.ProductID == temp)
                    {
                        temp = GenerateRandomNum(part);
                    }
                }
            }


            return temp;
        }

        // Part Functions
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

        public static bool DeletePart(int id)
        {
            Part part = LookupPart(id);
            if (part == null)
            {
                return false;
            }
            else
            {
                Parts.Remove(part);
                return true;
            }
        }

        public static Part LookupPart(int id)
        {
            foreach (Part part in Parts)
            {
                if (id == part.PartID)
                {
                    return part;
                }
            }
            //
            Part emptyp = new InHouse();
            return emptyp;
        }

        public static void UpdatePart(int id, Part part)
        {
            DeletePart(id);
            AddPart(part);

        }

        // Product Functions
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        public static bool RemoveProduct(int id)
        {
            Product prod = LookupProduct(id);
            if (prod == null)
            {
                MessageBox.Show("Error: Pruduct Not Found");
                return false;
            }
            else
            {
                Products.Remove(prod);
                return true;
            }

        }

        public static Product LookupProduct(int id)
        {
            foreach (Product prod in Products)
            {
                if (id == prod.ProductID)
                {
                    return prod;
                }
            }
            //
            Product empty = null;
            return empty;
        }

        public static void UpdateProduct(int id, Product product)
        {
            
            foreach (Product prod in Products)
            {
                if (prod.ProductID == id)
                {
                    prod.Name = product.Name;
                    prod.Instock = product.Instock;
                    prod.Price = product.Price;
                    prod.Max = product.Max;
                    prod.Min = product.Min;
                    prod.AssociatedParts = product.AssociatedParts;
                    return;
                }
            }
        }


        


        public static void ExampleItems()
        {
            //Example Items for testing
            Product exampleProd = new Product(GenerateRandomNum(false), "Example Product", 5, "$5.0", 10, 5);
            Product exampleProd2 = new Product(GenerateRandomNum(false), "Example Product2", 10, "$5.0", 12, 5);
            Products.Add(exampleProd2);
            Products.Add(exampleProd);

            Part exampleInPart = new InHouse(GenerateRandomNum(true), "Example In Part", 10, "$5.0", 20, 10, 1001);
            Part exampleOutPart = new Outsourced(GenerateRandomNum(true), "Example Out Part", 30, "$1.0", 45, 10, "Test Co.");
            Parts.Add(exampleInPart);
            Parts.Add(exampleOutPart);

        }

    }    
}
