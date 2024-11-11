using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
            Inventory.ExampleItems(); //Example Items for testing
            
            partGridView.DataSource = Inventory.Parts;
            productGridView.DataSource = Inventory.Products;


        }


        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Part Functions
        private void paddbtn_Click(object sender, EventArgs e)
        {
            //Opens Add Parts window
            new AddPart().ShowDialog();
        }
        private void pmodify_Click(object sender, EventArgs e)
        {
            //Opens Modify Part window
            if (partGridView.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
            {
                InHouse selectedPart = (InHouse)partGridView.SelectedRows[0].DataBoundItem;
                new AddPart(selectedPart).ShowDialog();
            }
            else
            {
                Outsourced selectedPart = (Outsourced)partGridView.SelectedRows[0].DataBoundItem;
                new AddPart(selectedPart).ShowDialog();
            }
        }
        private void pdelete_Click(object sender, EventArgs e)
        {
            //Asks if user wants to delete selected Part if so, then removes it from Part list
            DialogResult Confirm = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (Confirm == DialogResult.Yes)
            {
                if (partGridView.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
                {
                    InHouse selectedPart = (InHouse)partGridView.SelectedRows[0].DataBoundItem;
                    Inventory.DeletePart(selectedPart.PartID);
                }
                else
                {
                    Outsourced selectedPart = (Outsourced)partGridView.SelectedRows[0].DataBoundItem;
                    Inventory.DeletePart(selectedPart.PartID);
                }
                // update display
                partGridView.Update();
                partGridView.Refresh();
            }
            else { return; }
            
        }
        private void psearchbtn_Click(object sender, EventArgs e)
        {
            //Searches Part List by ID and selects the row if there
            try
            {
                bool found = false;
                int id = int.Parse(partsSearchtxt.Text);
                Part same = Inventory.LookupPart(id);
                partGridView.ClearSelection();
                foreach (DataGridViewRow row in partGridView.Rows)
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

        //Product Functions
        private void oaddbtn_Click(object sender, EventArgs e)
        {
            //Opens Add Products Window
            new AddProduct().ShowDialog();
        }

        private void omodify_Click(object sender, EventArgs e)
        {
            //Opens Modify Products Window
            Product selected = (Product)productGridView.SelectedRows[0].DataBoundItem;
            new AddProduct(selected).ShowDialog();
        }
        private void odelete_Click(object sender, EventArgs e)
        {
            //Asks if user wants to delete selected Product if so, then removes it from Product list
            
            Product selectedProduct = (Product)productGridView.SelectedRows[0].DataBoundItem;
            if (selectedProduct.AssociatedParts.Count == 0)
            {
                DialogResult Confirm = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
                if (Confirm == DialogResult.Yes)
                {
                    Inventory.RemoveProduct(selectedProduct.ProductID);
                    // update display
                    productGridView.Update();
                    productGridView.Refresh();
                }

            }
            else
            {
                MessageBox.Show("There are still parts associated with this. Please remove them before deleting this Product");
            }
            
            
        }

        private void osearchbtn_Click(object sender, EventArgs e)
        {
            //Searches Products List by ID and selects the row if there
            try
            {
                bool found = false;
                int id = int.Parse(productSearchtxt.Text);
                Product same = Inventory.LookupProduct(id);
                productGridView.ClearSelection();
                foreach (DataGridViewRow row in productGridView.Rows)
                {
                    Product prod = (Product)row.DataBoundItem;
                    if (prod.ProductID == same.ProductID)
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
                    MessageBox.Show("Error: Product could not be found");
                }
            }
            catch 
            {
                MessageBox.Show("Error: Product could not be found");
                return; 
            }
            
        }

        
    }
}
