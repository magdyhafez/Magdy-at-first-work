namespace WindowsFormsApplication6
{
    partial class Form6Bill
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
            this.OID = new System.Windows.Forms.TextBox();
            this.CID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgOneOrder = new System.Windows.Forms.DataGridView();
            this.OrderTotal = new System.Windows.Forms.TextBox();
            this.CuName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgOneOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // OID
            // 
            this.OID.Location = new System.Drawing.Point(52, 29);
            this.OID.Name = "OID";
            this.OID.Size = new System.Drawing.Size(100, 20);
            this.OID.TabIndex = 1;
            // 
            // CID
            // 
            this.CID.Location = new System.Drawing.Point(52, 79);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(100, 20);
            this.CID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "OrderId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(52, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Order Total";
            // 
            // dgOneOrder
            // 
            this.dgOneOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOneOrder.Location = new System.Drawing.Point(227, 13);
            this.dgOneOrder.Name = "dgOneOrder";
            this.dgOneOrder.Size = new System.Drawing.Size(351, 237);
            this.dgOneOrder.TabIndex = 0;
            this.dgOneOrder.Visible = false;
            // 
            // OrderTotal
            // 
            this.OrderTotal.Enabled = false;
            this.OrderTotal.Location = new System.Drawing.Point(52, 230);
            this.OrderTotal.Name = "OrderTotal";
            this.OrderTotal.Size = new System.Drawing.Size(100, 20);
            this.OrderTotal.TabIndex = 8;
            // 
            // CuName
            // 
            this.CuName.Enabled = false;
            this.CuName.Location = new System.Drawing.Point(52, 166);
            this.CuName.Name = "CuName";
            this.CuName.Size = new System.Drawing.Size(100, 20);
            this.CuName.TabIndex = 6;
            // 
            // Form6Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(590, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CuName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.OID);
            this.Controls.Add(this.dgOneOrder);
            this.Name = "Form6Bill";
            this.Text = "Form6Bill";
            this.Load += new System.EventHandler(this.Form6Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOneOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OID;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgOneOrder;
        private System.Windows.Forms.TextBox OrderTotal;
        private System.Windows.Forms.TextBox CuName;
    }
}