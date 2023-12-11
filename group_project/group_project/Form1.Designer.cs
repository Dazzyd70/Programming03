namespace group_project
{
    partial class Form1
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Remove = new System.Windows.Forms.TabPage();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.TabPage();
            this.Result_Output_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.LastName_textbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Address_textbox = new System.Windows.Forms.TextBox();
            this.Phone_textbox = new System.Windows.Forms.TextBox();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.FirstName_textbox = new System.Windows.Forms.TextBox();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.Accessories_checkbox = new System.Windows.Forms.CheckBox();
            this.Office_checkbox = new System.Windows.Forms.CheckBox();
            this.Games_checkbox = new System.Windows.Forms.CheckBox();
            this.Hardward_checkbox = new System.Windows.Forms.CheckBox();
            this.Software_checkbox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.Phone_label = new System.Windows.Forms.Label();
            this.Email_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1116, 571);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(4, 22);
            this.Remove.Name = "Remove";
            this.Remove.Padding = new System.Windows.Forms.Padding(3);
            this.Remove.Size = new System.Drawing.Size(1116, 571);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Home);
            this.TabControl.Controls.Add(this.Add);
            this.TabControl.Controls.Add(this.Remove);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Location = new System.Drawing.Point(3, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1124, 597);
            this.TabControl.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.dataGridView1);
            this.Home.Controls.Add(this.Save);
            this.Home.Controls.Add(this.Order);
            this.Home.Controls.Add(this.Delete);
            this.Home.Controls.Add(this.Button1);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1116, 571);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(980, 380);
            this.dataGridView1.TabIndex = 38;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(825, 452);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(228, 75);
            this.Save.TabIndex = 29;
            this.Save.Text = "Save to File";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(565, 452);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(254, 76);
            this.Order.TabIndex = 28;
            this.Order.Text = "Order by Name";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(305, 452);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(254, 76);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Remove Record";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(73, 452);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(226, 76);
            this.Button1.TabIndex = 26;
            this.Button1.Text = "Add Record";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Add
            // 
            this.Add.Controls.Add(this.Result_Output_label);
            this.Add.Controls.Add(this.label1);
            this.Add.Controls.Add(this.Submit);
            this.Add.Controls.Add(this.LastName_textbox);
            this.Add.Controls.Add(this.label13);
            this.Add.Controls.Add(this.Address_textbox);
            this.Add.Controls.Add(this.Phone_textbox);
            this.Add.Controls.Add(this.Email_textbox);
            this.Add.Controls.Add(this.FirstName_textbox);
            this.Add.Controls.Add(this.ID_textbox);
            this.Add.Controls.Add(this.Accessories_checkbox);
            this.Add.Controls.Add(this.Office_checkbox);
            this.Add.Controls.Add(this.Games_checkbox);
            this.Add.Controls.Add(this.Hardward_checkbox);
            this.Add.Controls.Add(this.Software_checkbox);
            this.Add.Controls.Add(this.label11);
            this.Add.Controls.Add(this.label8);
            this.Add.Controls.Add(this.label6);
            this.Add.Controls.Add(this.Address_label);
            this.Add.Controls.Add(this.Phone_label);
            this.Add.Controls.Add(this.Email_label);
            this.Add.Controls.Add(this.Name_label);
            this.Add.Controls.Add(this.ID_label);
            this.Add.Controls.Add(this.label10);
            this.Add.Controls.Add(this.label9);
            this.Add.Controls.Add(this.label7);
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(1116, 571);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Result_Output_label
            // 
            this.Result_Output_label.AutoSize = true;
            this.Result_Output_label.Location = new System.Drawing.Point(603, 453);
            this.Result_Output_label.Name = "Result_Output_label";
            this.Result_Output_label.Size = new System.Drawing.Size(0, 13);
            this.Result_Output_label.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Result:";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(25, 422);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(308, 73);
            this.Submit.TabIndex = 30;
            this.Submit.Text = "Register New Client";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // LastName_textbox
            // 
            this.LastName_textbox.Location = new System.Drawing.Point(245, 86);
            this.LastName_textbox.Name = "LastName_textbox";
            this.LastName_textbox.Size = new System.Drawing.Size(169, 20);
            this.LastName_textbox.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Selected Products";
            // 
            // Address_textbox
            // 
            this.Address_textbox.Location = new System.Drawing.Point(89, 273);
            this.Address_textbox.Name = "Address_textbox";
            this.Address_textbox.Size = new System.Drawing.Size(595, 20);
            this.Address_textbox.TabIndex = 26;
            // 
            // Phone_textbox
            // 
            this.Phone_textbox.Location = new System.Drawing.Point(89, 210);
            this.Phone_textbox.Name = "Phone_textbox";
            this.Phone_textbox.Size = new System.Drawing.Size(139, 20);
            this.Phone_textbox.TabIndex = 25;
            // 
            // Email_textbox
            // 
            this.Email_textbox.Location = new System.Drawing.Point(89, 146);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(139, 20);
            this.Email_textbox.TabIndex = 24;
            // 
            // FirstName_textbox
            // 
            this.FirstName_textbox.Location = new System.Drawing.Point(89, 86);
            this.FirstName_textbox.Name = "FirstName_textbox";
            this.FirstName_textbox.Size = new System.Drawing.Size(139, 20);
            this.FirstName_textbox.TabIndex = 23;
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(89, 27);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(139, 20);
            this.ID_textbox.TabIndex = 22;
            this.ID_textbox.Text = "fgbsrgn";
            // 
            // Accessories_checkbox
            // 
            this.Accessories_checkbox.AutoSize = true;
            this.Accessories_checkbox.Location = new System.Drawing.Point(537, 377);
            this.Accessories_checkbox.Name = "Accessories_checkbox";
            this.Accessories_checkbox.Size = new System.Drawing.Size(83, 17);
            this.Accessories_checkbox.TabIndex = 21;
            this.Accessories_checkbox.Text = "Accessories";
            this.Accessories_checkbox.UseVisualStyleBackColor = true;
            // 
            // Office_checkbox
            // 
            this.Office_checkbox.AutoSize = true;
            this.Office_checkbox.Location = new System.Drawing.Point(399, 377);
            this.Office_checkbox.Name = "Office_checkbox";
            this.Office_checkbox.Size = new System.Drawing.Size(83, 17);
            this.Office_checkbox.TabIndex = 20;
            this.Office_checkbox.Text = "Office Tools";
            this.Office_checkbox.UseVisualStyleBackColor = true;
            // 
            // Games_checkbox
            // 
            this.Games_checkbox.AutoSize = true;
            this.Games_checkbox.Location = new System.Drawing.Point(275, 377);
            this.Games_checkbox.Name = "Games_checkbox";
            this.Games_checkbox.Size = new System.Drawing.Size(59, 17);
            this.Games_checkbox.TabIndex = 19;
            this.Games_checkbox.Text = "Games";
            this.Games_checkbox.UseVisualStyleBackColor = true;
            // 
            // Hardward_checkbox
            // 
            this.Hardward_checkbox.AutoSize = true;
            this.Hardward_checkbox.Location = new System.Drawing.Point(142, 377);
            this.Hardward_checkbox.Name = "Hardward_checkbox";
            this.Hardward_checkbox.Size = new System.Drawing.Size(102, 17);
            this.Hardward_checkbox.TabIndex = 18;
            this.Hardward_checkbox.Text = "Laptops and PC";
            this.Hardward_checkbox.UseVisualStyleBackColor = true;
            // 
            // Software_checkbox
            // 
            this.Software_checkbox.AutoSize = true;
            this.Software_checkbox.Location = new System.Drawing.Point(26, 377);
            this.Software_checkbox.Name = "Software_checkbox";
            this.Software_checkbox.Size = new System.Drawing.Size(68, 17);
            this.Software_checkbox.TabIndex = 11;
            this.Software_checkbox.Text = "Software";
            this.Software_checkbox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 14;
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(20, 280);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(45, 13);
            this.Address_label.TabIndex = 4;
            this.Address_label.Text = "Address";
            // 
            // Phone_label
            // 
            this.Phone_label.AutoSize = true;
            this.Phone_label.Location = new System.Drawing.Point(20, 213);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(48, 13);
            this.Phone_label.TabIndex = 3;
            this.Phone_label.Text = "Phone #";
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Location = new System.Drawing.Point(20, 153);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(32, 13);
            this.Email_label.TabIndex = 2;
            this.Email_label.Text = "Email";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(20, 86);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(35, 13);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "Name";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(20, 23);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(18, 13);
            this.ID_label.TabIndex = 0;
            this.ID_label.Text = "ID";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 609);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage Remove;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button Save;
        internal System.Windows.Forms.Button Order;
        internal System.Windows.Forms.Button Delete;
        internal System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.CheckBox Software_checkbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label Phone_label;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Accessories_checkbox;
        private System.Windows.Forms.CheckBox Office_checkbox;
        private System.Windows.Forms.CheckBox Games_checkbox;
        private System.Windows.Forms.CheckBox Hardward_checkbox;
        private System.Windows.Forms.TextBox Address_textbox;
        private System.Windows.Forms.TextBox Phone_textbox;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.TextBox FirstName_textbox;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox LastName_textbox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Result_Output_label;
        private System.Windows.Forms.Label label1;
    }
}

