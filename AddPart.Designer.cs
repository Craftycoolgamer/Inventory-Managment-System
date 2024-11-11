namespace Inventory_Managment_System
{
    partial class AddPart
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
            inbtn = new RadioButton();
            outbtn = new RadioButton();
            AddAndModifyPartLable = new Label();
            idlbl = new Label();
            namelbl = new Label();
            inventorylbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            idorname = new Label();
            idtxt = new RichTextBox();
            nametxt = new RichTextBox();
            inventorytxt = new RichTextBox();
            pricetxt = new RichTextBox();
            maxtxt = new RichTextBox();
            machineIDtxt = new RichTextBox();
            mintxt = new RichTextBox();
            save = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // inbtn
            // 
            inbtn.AutoSize = true;
            inbtn.Checked = true;
            inbtn.Location = new Point(150, 19);
            inbtn.Name = "inbtn";
            inbtn.Size = new Size(74, 19);
            inbtn.TabIndex = 1;
            inbtn.TabStop = true;
            inbtn.Text = "In-House";
            inbtn.UseVisualStyleBackColor = true;
            inbtn.CheckedChanged += inbtn_CheckedChanged;
            // 
            // outbtn
            // 
            outbtn.AutoSize = true;
            outbtn.Location = new Point(247, 20);
            outbtn.Name = "outbtn";
            outbtn.Size = new Size(80, 19);
            outbtn.TabIndex = 2;
            outbtn.TabStop = true;
            outbtn.Text = "Outsource";
            outbtn.UseVisualStyleBackColor = true;
            outbtn.CheckedChanged += outbtn_CheckedChanged;
            // 
            // AddAndModifyPartLable
            // 
            AddAndModifyPartLable.AutoSize = true;
            AddAndModifyPartLable.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddAndModifyPartLable.Location = new Point(12, 9);
            AddAndModifyPartLable.Name = "AddAndModifyPartLable";
            AddAndModifyPartLable.Size = new Size(92, 25);
            AddAndModifyPartLable.TabIndex = 3;
            AddAndModifyPartLable.Text = "Add Part";
            // 
            // idlbl
            // 
            idlbl.AutoSize = true;
            idlbl.Font = new Font("Segoe UI", 12F);
            idlbl.Location = new Point(115, 76);
            idlbl.Name = "idlbl";
            idlbl.Size = new Size(25, 21);
            idlbl.TabIndex = 4;
            idlbl.Text = "ID";
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Segoe UI", 12F);
            namelbl.Location = new Point(91, 119);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(52, 21);
            namelbl.TabIndex = 5;
            namelbl.Text = "Name";
            // 
            // inventorylbl
            // 
            inventorylbl.AutoSize = true;
            inventorylbl.Font = new Font("Segoe UI", 12F);
            inventorylbl.Location = new Point(64, 162);
            inventorylbl.Name = "inventorylbl";
            inventorylbl.Size = new Size(76, 21);
            inventorylbl.TabIndex = 6;
            inventorylbl.Text = "Inventory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(51, 203);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 7;
            label1.Text = "Price / Cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(101, 249);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 8;
            label2.Text = "Max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(270, 251);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 9;
            label3.Text = "Min";
            // 
            // idorname
            // 
            idorname.AutoSize = true;
            idorname.Font = new Font("Segoe UI", 12F);
            idorname.Location = new Point(20, 294);
            idorname.Name = "idorname";
            idorname.RightToLeft = RightToLeft.No;
            idorname.Size = new Size(88, 21);
            idorname.TabIndex = 10;
            idorname.Text = "Machine ID";
            // 
            // idtxt
            // 
            idtxt.BackColor = SystemColors.Control;
            idtxt.Enabled = false;
            idtxt.Location = new Point(161, 76);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(179, 37);
            idtxt.TabIndex = 11;
            idtxt.Text = "";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(161, 119);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(179, 37);
            nametxt.TabIndex = 12;
            nametxt.Text = "";
            // 
            // inventorytxt
            // 
            inventorytxt.Location = new Point(161, 162);
            inventorytxt.Name = "inventorytxt";
            inventorytxt.Size = new Size(179, 37);
            inventorytxt.TabIndex = 13;
            inventorytxt.Text = "";
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(161, 205);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(179, 37);
            pricetxt.TabIndex = 14;
            pricetxt.Text = "";
            // 
            // maxtxt
            // 
            maxtxt.Location = new Point(161, 251);
            maxtxt.Name = "maxtxt";
            maxtxt.Size = new Size(86, 37);
            maxtxt.TabIndex = 15;
            maxtxt.Text = "";
            // 
            // machineIDtxt
            // 
            machineIDtxt.Location = new Point(161, 294);
            machineIDtxt.Name = "machineIDtxt";
            machineIDtxt.Size = new Size(179, 37);
            machineIDtxt.TabIndex = 16;
            machineIDtxt.Text = "";
            // 
            // mintxt
            // 
            mintxt.Location = new Point(324, 249);
            mintxt.Name = "mintxt";
            mintxt.Size = new Size(86, 37);
            mintxt.TabIndex = 17;
            mintxt.Text = "";
            // 
            // save
            // 
            save.BackColor = SystemColors.Control;
            save.Location = new Point(299, 350);
            save.Name = "save";
            save.Size = new Size(70, 40);
            save.TabIndex = 18;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(380, 350);
            cancel.Name = "cancel";
            cancel.Size = new Size(70, 40);
            cancel.TabIndex = 19;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 402);
            Controls.Add(cancel);
            Controls.Add(save);
            Controls.Add(mintxt);
            Controls.Add(machineIDtxt);
            Controls.Add(maxtxt);
            Controls.Add(pricetxt);
            Controls.Add(inventorytxt);
            Controls.Add(nametxt);
            Controls.Add(idtxt);
            Controls.Add(idorname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inventorylbl);
            Controls.Add(namelbl);
            Controls.Add(idlbl);
            Controls.Add(AddAndModifyPartLable);
            Controls.Add(outbtn);
            Controls.Add(inbtn);
            Name = "AddPart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton inbtn;
        private RadioButton outbtn;
        private Label AddAndModifyPartLable;
        private Label idlbl;
        private Label namelbl;
        private Label inventorylbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label idorname;
        private RichTextBox idtxt;
        private RichTextBox nametxt;
        private RichTextBox inventorytxt;
        private RichTextBox pricetxt;
        private RichTextBox maxtxt;
        private RichTextBox machineIDtxt;
        private RichTextBox mintxt;
        private Button save;
        private Button cancel;
    }
}