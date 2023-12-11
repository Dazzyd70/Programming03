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
            this.searchInput = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.TabPage();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Remove.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.Remove.Controls.Add(this.button4);
            this.Remove.Controls.Add(this.button3);
            this.Remove.Controls.Add(this.button2);
            this.Remove.Controls.Add(this.dataGridView2);
            this.Remove.Controls.Add(this.textBox1);
            this.Remove.Controls.Add(this.searchInput);
            this.Remove.Location = new System.Drawing.Point(4, 22);
            this.Remove.Name = "Remove";
            this.Remove.Padding = new System.Windows.Forms.Padding(3);
            this.Remove.Size = new System.Drawing.Size(1116, 571);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Search";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(145, 26);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(310, 20);
            this.searchInput.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(1116, 571);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
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
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(305, 452);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(254, 76);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Remove Record";
            this.Delete.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(68, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 13);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Input Client ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(68, 75);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(980, 298);
            this.dataGridView2.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 86);
            this.button2.TabIndex = 40;
            this.button2.Text = "Delete Record";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 86);
            this.button3.TabIndex = 41;
            this.button3.Text = "Print Record";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(473, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 86);
            this.button4.TabIndex = 42;
            this.button4.Text = "Cancel Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 609);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Remove.ResumeLayout(false);
            this.Remove.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage Remove;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button Save;
        internal System.Windows.Forms.Button Order;
        internal System.Windows.Forms.Button Delete;
        internal System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

