namespace Inventory_Managment_System
{
    partial class mainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            psearchbtn = new Button();
            partsSearchtxt = new TextBox();
            partGridView = new DataGridView();
            paddbtn = new Button();
            pmodify = new Button();
            pdelete = new Button();
            odelete = new Button();
            omodify = new Button();
            oaddbtn = new Button();
            productGridView = new DataGridView();
            productSearchtxt = new TextBox();
            osearchbtn = new Button();
            exit = new Button();
            title = new Label();
            partslbl = new Label();
            productslbl = new Label();
            ((System.ComponentModel.ISupportInitialize)partGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 15;
            // 
            // psearchbtn
            // 
            psearchbtn.Location = new Point(420, 64);
            psearchbtn.Name = "psearchbtn";
            psearchbtn.Size = new Size(75, 23);
            psearchbtn.TabIndex = 1;
            psearchbtn.Text = "Search";
            psearchbtn.UseVisualStyleBackColor = true;
            psearchbtn.Click += psearchbtn_Click;
            // 
            // partsSearchtxt
            // 
            partsSearchtxt.Location = new Point(521, 64);
            partsSearchtxt.Name = "partsSearchtxt";
            partsSearchtxt.Size = new Size(134, 23);
            partsSearchtxt.TabIndex = 3;
            // 
            // partGridView
            // 
            partGridView.AllowUserToAddRows = false;
            partGridView.AllowUserToDeleteRows = false;
            partGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partGridView.Location = new Point(12, 93);
            partGridView.Name = "partGridView";
            partGridView.ReadOnly = true;
            partGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partGridView.Size = new Size(643, 294);
            partGridView.TabIndex = 4;
            // 
            // paddbtn
            // 
            paddbtn.Location = new Point(469, 393);
            paddbtn.Name = "paddbtn";
            paddbtn.Size = new Size(58, 35);
            paddbtn.TabIndex = 5;
            paddbtn.Text = "Add";
            paddbtn.UseVisualStyleBackColor = true;
            paddbtn.Click += paddbtn_Click;
            // 
            // pmodify
            // 
            pmodify.Location = new Point(533, 393);
            pmodify.Name = "pmodify";
            pmodify.Size = new Size(58, 35);
            pmodify.TabIndex = 6;
            pmodify.Text = "Modify";
            pmodify.UseVisualStyleBackColor = true;
            pmodify.Click += pmodify_Click;
            // 
            // pdelete
            // 
            pdelete.Location = new Point(597, 393);
            pdelete.Name = "pdelete";
            pdelete.Size = new Size(58, 35);
            pdelete.TabIndex = 7;
            pdelete.Text = "Delete";
            pdelete.UseVisualStyleBackColor = true;
            pdelete.Click += pdelete_Click;
            // 
            // odelete
            // 
            odelete.Location = new Point(1290, 393);
            odelete.Name = "odelete";
            odelete.Size = new Size(58, 35);
            odelete.TabIndex = 13;
            odelete.Text = "Delete";
            odelete.UseVisualStyleBackColor = true;
            odelete.Click += odelete_Click;
            // 
            // omodify
            // 
            omodify.Location = new Point(1226, 393);
            omodify.Name = "omodify";
            omodify.Size = new Size(58, 35);
            omodify.TabIndex = 12;
            omodify.Text = "Modify";
            omodify.UseVisualStyleBackColor = true;
            omodify.Click += omodify_Click;
            // 
            // oaddbtn
            // 
            oaddbtn.Location = new Point(1162, 393);
            oaddbtn.Name = "oaddbtn";
            oaddbtn.Size = new Size(58, 35);
            oaddbtn.TabIndex = 11;
            oaddbtn.Text = "Add";
            oaddbtn.UseVisualStyleBackColor = true;
            oaddbtn.Click += oaddbtn_Click;
            // 
            // productGridView
            // 
            productGridView.AllowUserToAddRows = false;
            productGridView.AllowUserToDeleteRows = false;
            productGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGridView.Location = new Point(705, 93);
            productGridView.Name = "productGridView";
            productGridView.ReadOnly = true;
            productGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productGridView.Size = new Size(643, 294);
            productGridView.TabIndex = 10;
            // 
            // productSearchtxt
            // 
            productSearchtxt.Location = new Point(1214, 64);
            productSearchtxt.Name = "productSearchtxt";
            productSearchtxt.Size = new Size(134, 23);
            productSearchtxt.TabIndex = 9;
            // 
            // osearchbtn
            // 
            osearchbtn.Location = new Point(1113, 64);
            osearchbtn.Name = "osearchbtn";
            osearchbtn.Size = new Size(75, 23);
            osearchbtn.TabIndex = 8;
            osearchbtn.Text = "Search";
            osearchbtn.UseVisualStyleBackColor = true;
            osearchbtn.Click += osearchbtn_Click;
            // 
            // exit
            // 
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(1269, 450);
            exit.Name = "exit";
            exit.Size = new Size(79, 44);
            exit.TabIndex = 14;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.Location = new Point(12, 8);
            title.Name = "title";
            title.Size = new Size(335, 32);
            title.TabIndex = 16;
            title.Text = "Inventory Managment System";
            // 
            // partslbl
            // 
            partslbl.AutoSize = true;
            partslbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            partslbl.Location = new Point(12, 62);
            partslbl.Margin = new Padding(0, 0, 3, 0);
            partslbl.Name = "partslbl";
            partslbl.Size = new Size(58, 25);
            partslbl.TabIndex = 17;
            partslbl.Text = "Parts";
            // 
            // productslbl
            // 
            productslbl.AutoSize = true;
            productslbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productslbl.Location = new Point(705, 62);
            productslbl.Margin = new Padding(0, 0, 3, 0);
            productslbl.Name = "productslbl";
            productslbl.Size = new Size(92, 25);
            productslbl.TabIndex = 18;
            productslbl.Text = "Products";
            // 
            // mainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 507);
            Controls.Add(productslbl);
            Controls.Add(partslbl);
            Controls.Add(title);
            Controls.Add(exit);
            Controls.Add(odelete);
            Controls.Add(omodify);
            Controls.Add(oaddbtn);
            Controls.Add(productGridView);
            Controls.Add(productSearchtxt);
            Controls.Add(osearchbtn);
            Controls.Add(pdelete);
            Controls.Add(pmodify);
            Controls.Add(paddbtn);
            Controls.Add(partGridView);
            Controls.Add(partsSearchtxt);
            Controls.Add(psearchbtn);
            Controls.Add(label1);
            Name = "mainScreen";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)partGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button psearchbtn;
        private TextBox partsSearchtxt;
        public DataGridView partGridView;
        private Button paddbtn;
        private Button pmodify;
        private Button pdelete;
        private Button odelete;
        private Button omodify;
        private Button oaddbtn;
        public DataGridView productGridView;
        private TextBox productSearchtxt;
        private Button osearchbtn;
        private Button exit;
        private Label title;
        private Label partslbl;
        private Label productslbl;
    }
}
