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
            this.Add = new System.Windows.Forms.TabPage();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Button1 = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Home = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Home.SuspendLayout();
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
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(305, 452);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(254, 76);
            this.Insert.TabIndex = 27;
            this.Insert.Text = "Remove Record";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(565, 452);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(254, 76);
            this.Delete.TabIndex = 28;
            this.Delete.Text = "Order by Name";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(825, 452);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(228, 75);
            this.Search.TabIndex = 29;
            this.Search.Text = "Save to File";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(980, 380);
            this.dataGridView1.TabIndex = 38;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.dataGridView1);
            this.Home.Controls.Add(this.Search);
            this.Home.Controls.Add(this.Delete);
            this.Home.Controls.Add(this.Insert);
            this.Home.Controls.Add(this.Button1);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1116, 571);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage Remove;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button Search;
        internal System.Windows.Forms.Button Delete;
        internal System.Windows.Forms.Button Insert;
        internal System.Windows.Forms.Button Button1;
    }
}

