using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_Managment_System
{
    public partial class AddProduct : Form
    {
        mainScreen Main = (mainScreen)Application.OpenForms["mainScreen"];
        private Product product;
        
        //variable to switch between Modify and Add windows
        private static bool addData;
        

        public AddProduct()
        {
            InitializeComponent();
            AddAndModifyProductLable.Text = "Add Products";
            addData = true;

            var topTable = new BindingSource();
            topTable.DataSource = Inventory.Parts;
            dataGridViewTop.DataSource = topTable;
            var bottomTable = new BindingSource();
            product = new Product();
            bottomTable.DataSource = product.AssociatedParts;
            dataGridViewBottom.DataSource = bottomTable;

            idtxt.Text = Inventory.GenerateRandomNum(false).ToString();
        }
        public AddProduct(Product prod)
        {
            InitializeComponent();
            AddAndModifyProductLable.Text = "Modify Products";
            addData = false;

            product = prod;
            
            //var topTable = new BindingSource();
            //topTable.DataSource = Inventory.Parts;
            dataGridViewTop.DataSource = Inventory.Parts;
            //var bottomTable = new BindingSource();
            //bottomTable.DataSource = product.AssociatedParts;
            dataGridViewBottom.DataSource = product.AssociatedParts;
            

            idtxt.Text = prod.ProductID.ToString();
            nametxt.Text = prod.Name.ToString();
            inStocktxt.Text = prod.Instock.ToString();
            pricetxt.Text = prod.Price.ToString();
            maxtxt.Text = prod.Max.ToString();
            mintxt.Text = prod.Min.ToString();

        }


        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int InStock;
            string price;
            int max;
            int min;

            try
            {
                min = int.Parse(mintxt.Text);
                max = int.Parse(maxtxt.Text);
                InStock = int.Parse(inStocktxt.Text);
                decimal pricetemp = decimal.Parse(pricetxt.Text.Substring(1));
            }
            catch
            {
                MessageBox.Show("Inventory, Price, Max, and Min text feilds must be numbers.");
                return;
            }

            int id = int.Parse(idtxt.Text);
            string Name = nametxt.Text;
            price = pricetxt.Text.ToString();

            if (min > max)
            {
                MessageBox.Show("Max must be greater than Min");
                return;
            }
            if (max < InStock || InStock < min)
            {
                MessageBox.Show("Inventory must be between max and min");
                return;
            }
            

            if (addData)
            {
                product.ProductID = id;
                product.Name = Name;
                product.Instock = InStock;
                product.Price = price;
                product.Max = max;
                product.Min = min;
                Inventory.AddProduct(product);
            }
            else
            {
                product.ProductID = id;
                product.Name = Name;
                product.Instock = InStock;
                product.Price = price;
                product.Max = max;
                product.Min = min;

                Inventory.UpdateProduct(id, product);
            }
           
            Close();
            Main.productGridView.Update();
            Main.productGridView.Refresh();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            //Asks if user wants to delete selected Part from the Product if so, then removes it from Associated Parts List
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Part part = (Part)dataGridViewBottom.CurrentRow.DataBoundItem;
                product.RemoveAssociatedPart(part.PartID);

                // update display
                dataGridViewTop.Update();
                dataGridViewTop.Refresh();
            }
            else { return; }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //Part part = (Part)dataGridViewTop.CurrentRow.DataBoundItem;
            Part part = (Part)dataGridViewTop.SelectedRows[0].DataBoundItem;
            product.AddAssociatedPart(part);

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                int id = int.Parse(searchtxt.Text);
                Part same = Inventory.LookupPart(id);
                dataGridViewTop.ClearSelection();
                foreach (DataGridViewRow row in dataGridViewTop.Rows)
                {
                    Part part = (Part)row.DataBoundItem;
                    if (part.PartID == same.PartID)
                    {
                        row.Selected = true;
                        found = true;
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Error: Part could not be found");
                }
            }
            catch
            {
                MessageBox.Show("Error: Part could not be found");
                return;
            }
        }
    }
}
