namespace Inventory_Managment_System
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cancel = new Button();
            save = new Button();
            mintxt = new RichTextBox();
            maxtxt = new RichTextBox();
            pricetxt = new RichTextBox();
            inStocktxt = new RichTextBox();
            nametxt = new RichTextBox();
            idtxt = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            inventorylbl = new Label();
            namelbl = new Label();
            idlbl = new Label();
            AddAndModifyProductLable = new Label();
            alllbl = new Label();
            addbtn = new Button();
            dataGridViewTop = new DataGridView();
            searchtxt = new TextBox();
            searchbtn = new Button();
            partslbl = new Label();
            deletebtn = new Button();
            dataGridViewBottom = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBottom).BeginInit();
            SuspendLayout();
            // 
            // cancel
            // 
            cancel.Location = new Point(1001, 637);
            cancel.Name = "cancel";
            cancel.Size = new Size(70, 40);
            cancel.TabIndex = 38;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // save
            // 
            save.CausesValidation = false;
            save.Location = new Point(920, 637);
            save.Name = "save";
            save.Size = new Size(70, 40);
            save.TabIndex = 37;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // mintxt
            // 
            mintxt.Location = new Point(321, 251);
            mintxt.Name = "mintxt";
            mintxt.Size = new Size(86, 37);
            mintxt.TabIndex = 36;
            mintxt.Text = "";
            // 
            // maxtxt
            // 
            maxtxt.Location = new Point(158, 253);
            maxtxt.Name = "maxtxt";
            maxtxt.Size = new Size(86, 37);
            maxtxt.TabIndex = 34;
            maxtxt.Text = "";
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(158, 207);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(179, 37);
            pricetxt.TabIndex = 33;
            pricetxt.Text = "";
            // 
            // inStocktxt
            // 
            inStocktxt.Location = new Point(158, 164);
            inStocktxt.Name = "inStocktxt";
            inStocktxt.Size = new Size(179, 37);
            inStocktxt.TabIndex = 32;
            inStocktxt.Text = "";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(158, 121);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(179, 37);
            nametxt.TabIndex = 31;
            nametxt.Text = "";
            // 
            // idtxt
            // 
            idtxt.BackColor = SystemColors.Control;
            idtxt.Enabled = false;
            idtxt.Location = new Point(158, 78);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(179, 37);
            idtxt.TabIndex = 30;
            idtxt.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(267, 253);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 28;
            label3.Text = "Min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(98, 251);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 27;
            label2.Text = "Max";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(48, 205);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 26;
            label1.Text = "Price / Cost";
            // 
            // inventorylbl
            // 
            inventorylbl.AutoSize = true;
            inventorylbl.Font = new Font("Segoe UI", 12F);
            inventorylbl.Location = new Point(61, 164);
            inventorylbl.Name = "inventorylbl";
            inventorylbl.Size = new Size(76, 21);
            inventorylbl.TabIndex = 25;
            inventorylbl.Text = "Inventory";
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Segoe UI", 12F);
            namelbl.Location = new Point(88, 121);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(52, 21);
            namelbl.TabIndex = 24;
            namelbl.Text = "Name";
            // 
            // idlbl
            // 
            idlbl.AutoSize = true;
            idlbl.Font = new Font("Segoe UI", 12F);
            idlbl.Location = new Point(112, 78);
            idlbl.Name = "idlbl";
            idlbl.Size = new Size(25, 21);
            idlbl.TabIndex = 23;
            idlbl.Text = "ID";
            // 
            // AddAndModifyProductLable
            // 
            AddAndModifyProductLable.AutoSize = true;
            AddAndModifyProductLable.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddAndModifyProductLable.Location = new Point(9, 11);
            AddAndModifyProductLable.Name = "AddAndModifyProductLable";
            AddAndModifyProductLable.Size = new Size(126, 25);
            AddAndModifyProductLable.TabIndex = 22;
            AddAndModifyProductLable.Text = "Add Product";
            // 
            // alllbl
            // 
            alllbl.AutoSize = true;
            alllbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alllbl.Location = new Point(535, 22);
            alllbl.Margin = new Padding(0, 0, 3, 0);
            alllbl.Name = "alllbl";
            alllbl.Size = new Size(178, 25);
            alllbl.TabIndex = 51;
            alllbl.Text = "All candidate Parts";
            // 
            // addbtn
            // 
            addbtn.Location = new Point(1062, 251);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(58, 35);
            addbtn.TabIndex = 42;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // dataGridViewTop
            // 
            dataGridViewTop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTop.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewTop.Location = new Point(535, 53);
            dataGridViewTop.Name = "dataGridViewTop";
            dataGridViewTop.ReadOnly = true;
            dataGridViewTop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTop.Size = new Size(585, 191);
            dataGridViewTop.TabIndex = 41;
            // 
            // searchtxt
            // 
            searchtxt.Location = new Point(986, 24);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(134, 23);
            searchtxt.TabIndex = 40;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(885, 24);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 39;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // partslbl
            // 
            partslbl.AutoSize = true;
            partslbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            partslbl.Location = new Point(535, 316);
            partslbl.Margin = new Padding(0, 0, 3, 0);
            partslbl.Name = "partslbl";
            partslbl.Size = new Size(313, 25);
            partslbl.TabIndex = 56;
            partslbl.Text = "Parts Associated with this Product";
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(1062, 545);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(58, 35);
            deletebtn.TabIndex = 55;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // dataGridViewBottom
            // 
            dataGridViewBottom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBottom.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewBottom.Location = new Point(535, 347);
            dataGridViewBottom.Name = "dataGridViewBottom";
            dataGridViewBottom.ReadOnly = true;
            dataGridViewBottom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBottom.Size = new Size(585, 191);
            dataGridViewBottom.TabIndex = 54;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 689);
            Controls.Add(partslbl);
            Controls.Add(deletebtn);
            Controls.Add(dataGridViewBottom);
            Controls.Add(alllbl);
            Controls.Add(addbtn);
            Controls.Add(dataGridViewTop);
            Controls.Add(searchtxt);
            Controls.Add(searchbtn);
            Controls.Add(cancel);
            Controls.Add(save);
            Controls.Add(mintxt);
            Controls.Add(maxtxt);
            Controls.Add(pricetxt);
            Controls.Add(inStocktxt);
            Controls.Add(nametxt);
            Controls.Add(idtxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inventorylbl);
            Controls.Add(namelbl);
            Controls.Add(idlbl);
            Controls.Add(AddAndModifyProductLable);
            Name = "AddProduct";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancel;
        private Button save;
        private RichTextBox mintxt;
        private RichTextBox maxtxt;
        private RichTextBox pricetxt;
        private RichTextBox inStocktxt;
        private RichTextBox nametxt;
        private RichTextBox idtxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label inventorylbl;
        private Label namelbl;
        private Label idlbl;
        private Label AddAndModifyProductLable;
        private Label alllbl;
        private Button addbtn;
        private DataGridView dataGridViewTop;
        private TextBox searchtxt;
        private Button searchbtn;
        private Label partslbl;
        private Button deletebtn;
        private DataGridView dataGridViewBottom;
    }
}