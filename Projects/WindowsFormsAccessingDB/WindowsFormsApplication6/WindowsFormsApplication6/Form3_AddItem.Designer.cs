namespace WindowsFormsApplication6
{
    partial class Form3_AddItem
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
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.INAME = new System.Windows.Forms.TextBox();
            this.IID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgItem = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.IPRICETXT = new System.Windows.Forms.TextBox();
            this.IPRICE = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.customerTableAdapter1 = new WindowsFormsApplication6.Stores2DataSetTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Add a new Item";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(51, 65);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(34, 13);
            this.Name.TabIndex = 16;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(21, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // INAME
            // 
            this.INAME.Location = new System.Drawing.Point(41, 92);
            this.INAME.Name = "INAME";
            this.INAME.Size = new System.Drawing.Size(100, 20);
            this.INAME.TabIndex = 13;
            this.INAME.TextChanged += new System.EventHandler(this.INAME_TextChanged);
            // 
            // IID
            // 
            this.IID.Location = new System.Drawing.Point(41, 42);
            this.IID.Name = "IID";
            this.IID.Size = new System.Drawing.Size(100, 20);
            this.IID.TabIndex = 12;
            this.IID.TextChanged += new System.EventHandler(this.IID_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(244, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgItem
            // 
            this.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItem.Location = new System.Drawing.Point(242, 21);
            this.dgItem.Name = "dgItem";
            this.dgItem.Size = new System.Drawing.Size(301, 173);
            this.dgItem.TabIndex = 18;
            this.dgItem.Visible = false;
            this.dgItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItem_CellClick);
            this.dgItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItem_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SlateBlue;
            this.button4.Location = new System.Drawing.Point(432, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "See All Items";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // IPRICETXT
            // 
            this.IPRICETXT.Location = new System.Drawing.Point(41, 135);
            this.IPRICETXT.Name = "IPRICETXT";
            this.IPRICETXT.Size = new System.Drawing.Size(100, 20);
            this.IPRICETXT.TabIndex = 20;
            this.IPRICETXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IPRICE
            // 
            this.IPRICE.AutoSize = true;
            this.IPRICE.Location = new System.Drawing.Point(49, 119);
            this.IPRICE.Name = "IPRICE";
            this.IPRICE.Size = new System.Drawing.Size(52, 13);
            this.IPRICE.TabIndex = 21;
            this.IPRICE.Text = "ItemPrice";
            this.IPRICE.Click += new System.EventHandler(this.IPRICE_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(432, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(574, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IPRICE);
            this.Controls.Add(this.IPRICETXT);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.INAME);
            this.Controls.Add(this.IID);
            this.Controls.Add(this.button2);
         //   this.Name = "Form3_AddItem";
            this.Text = "Form3_AddItem";
            this.Load += new System.EventHandler(this.Form3_AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox INAME;
        private System.Windows.Forms.TextBox IID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox IPRICETXT;
        private System.Windows.Forms.Label IPRICE;
        private System.Windows.Forms.Button button1;
        private Stores2DataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
    }
}