using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;



namespace Inventory_Managment_System
{
    public partial class AddPart : Form
    {

        mainScreen Main = (mainScreen)Application.OpenForms["mainScreen"];
        private static bool addData;

        public AddPart()
        {
            InitializeComponent();
            addData = true;
            AddAndModifyPartLable.Text = "Add Parts";
            //not quite working as intended id's can match
            idtxt.Text = Inventory.GenerateRandomNum(true).ToString();
        }
        public AddPart(InHouse part)
        {
            InitializeComponent();
            addData = false;
            AddAndModifyPartLable.Text = "Modify Parts";
            idtxt.Text = part.PartID.ToString();
            nametxt.Text = part.Name;
            inventorytxt.Text = part.InStock.ToString();
            pricetxt.Text = part.Price.ToString();
            maxtxt.Text = part.Max.ToString();
            mintxt.Text = part.Min.ToString();
            idorname.Text = "Machine ID";
            machineIDtxt.Text = part.MachineID.ToString();
            inbtn.Checked = true;
            outbtn.Checked = false;
        }
        public AddPart(Outsourced part)
        {
            InitializeComponent();
            addData = false;
            AddAndModifyPartLable.Text = "Modify Parts";
            idtxt.Text = part.PartID.ToString();
            nametxt.Text = part.Name;
            inventorytxt.Text = part.InStock.ToString();
            pricetxt.Text = part.Price.ToString();
            maxtxt.Text = part.Max.ToString();
            mintxt.Text = part.Min.ToString();
            idorname.Text = "Company Name";
            machineIDtxt.Text = part.CompanyName;
            inbtn.Checked = false;
            outbtn.Checked = true;
        }
        

        


        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inbtn_CheckedChanged(object sender, EventArgs e)
        {
            idorname.Text = "Machine ID";
        }

        private void outbtn_CheckedChanged(object sender, EventArgs e)
        {
            idorname.Text = "Company Name";
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
                InStock = int.Parse(inventorytxt.Text);
                decimal pricetemp = decimal.Parse(pricetxt.Text.Substring(1));
            }
            catch
            {
                MessageBox.Show("Inventory, Price, Max, and Min text feilds must be numbers.");
                return;
            }

            int id = int.Parse(idtxt.Text);
            string Name = nametxt.Text;
            InStock = int.Parse(inventorytxt.Text);
            price = pricetxt.Text;
            max = int.Parse(maxtxt.Text);
            min = int.Parse(mintxt.Text);

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
            

            if(inbtn.Checked)
            {  
                if (addData)
                {
                    InHouse inHouse = new InHouse(id, Name, InStock, price, max, min, int.Parse(machineIDtxt.Text));
                    Inventory.AddPart(inHouse);
                }
                else
                {
                    InHouse inHouse = new InHouse(id, Name, InStock, price, max, min, int.Parse(machineIDtxt.Text));
                    Inventory.UpdatePart(id, inHouse);
                }
                
            }
            else
            { 
                
                if (addData)
                {
                    Outsourced outsourced = new Outsourced(id, Name, InStock, price, max, min, machineIDtxt.Text);
                    Inventory.AddPart(outsourced);
                }
                else
                {
                    Outsourced outsourced = new Outsourced(id, Name, InStock, price, max, min, machineIDtxt.Text);
                    Inventory.UpdatePart(id, outsourced);
                }
            }

            Close();
            Main.partGridView.Update();
            Main.partGridView.Refresh();

        }
    }
}
