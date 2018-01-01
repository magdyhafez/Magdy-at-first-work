namespace WindowsFormsApplication6
{
    partial class Form5_OderDetails
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
            this.IPRICE = new System.Windows.Forms.Label();
            this.IID = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dgOrderDetails = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.CID = new System.Windows.Forms.TextBox();
            this.OID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IQ = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // IPRICE
            // 
            this.IPRICE.AutoSize = true;
            this.IPRICE.Location = new System.Drawing.Point(42, 126);
            this.IPRICE.Name = "IPRICE";
            this.IPRICE.Size = new System.Drawing.Size(22, 13);
            this.IPRICE.TabIndex = 32;
            this.IPRICE.Text = "IID";
            // 
            // IID
            // 
            this.IID.Location = new System.Drawing.Point(34, 152);
            this.IID.Name = "IID";
            this.IID.Size = new System.Drawing.Size(100, 20);
            this.IID.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(425, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "See All OrdersDetail";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgOrderDetails
            // 
            this.dgOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderDetails.Location = new System.Drawing.Point(235, 28);
            this.dgOrderDetails.Name = "dgOrderDetails";
            this.dgOrderDetails.Size = new System.Drawing.Size(333, 173);
            this.dgOrderDetails.TabIndex = 29;
            this.dgOrderDetails.Visible = false;
            this.dgOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrderDetails_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Add a new Item";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(44, 72);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(25, 13);
            this.Name.TabIndex = 27;
            this.Name.Text = "CID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "OID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(12, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CID
            // 
            this.CID.Location = new System.Drawing.Point(34, 99);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(100, 20);
            this.CID.TabIndex = 24;
            // 
            // OID
            // 
            this.OID.Location = new System.Drawing.Point(34, 49);
            this.OID.Name = "OID";
            this.OID.Size = new System.Drawing.Size(100, 20);
            this.OID.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(237, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Item Quantity";
            // 
            // IQ
            // 
            this.IQ.Location = new System.Drawing.Point(34, 201);
            this.IQ.Name = "IQ";
            this.IQ.Size = new System.Drawing.Size(100, 20);
            this.IQ.TabIndex = 34;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(425, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 35;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form5_OderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(606, 280);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.IQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IPRICE);
            this.Controls.Add(this.IID);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgOrderDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.OID);
            this.Controls.Add(this.button2);
        //    this.Name = "Form5_OderDetails";
            this.Text = "Form4_OderDetails";
            this.Load += new System.EventHandler(this.Form5_OderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPRICE;
        private System.Windows.Forms.TextBox IID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgOrderDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.TextBox OID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IQ;
        private System.Windows.Forms.Button button5;
    }
}