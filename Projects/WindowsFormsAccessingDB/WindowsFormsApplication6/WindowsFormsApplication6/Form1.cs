using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        // public DataGrid dg = new DataGrid();
        public DataSet ds = new DataSet();

        SqlConnection cs = new SqlConnection("Data Source=BILAP84-PC\\V2005;Initial Catalog=Stores2;User ID=sa;Password=sa");

        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da2 = new SqlDataAdapter();
        SqlCommandBuilder cmdbl;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Customer Window";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }


        private void button3_Click(object sender, EventArgs e)
        {

            da.InsertCommand = new SqlCommand("INSERT INTO Customer VALUES (@CuID,@CuNAME)", cs);
            da.InsertCommand.Parameters.Add("@CuID", SqlDbType.Int).Value = int.Parse(textBox1.Text);
            da.InsertCommand.Parameters.Add("@CuNAME", SqlDbType.VarChar).Value = textBox2.Text;

            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgCust.SelectedRows[0];
            //textBox3.Text= row.Cells["CustomerName"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgCust.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // clear the datagrid before using it 
            DataTable dt = (DataTable)dgCust.DataSource;
            if (dt != null)
                dt.Clear();

            dgCust.Refresh();
            dgCust.Visible = true;
            da.SelectCommand = new SqlCommand("SELECT* FROM Customer", cs);
            da.Fill(ds, "Cust");
            dgCust.DataSource = ds.Tables[0];

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3_AddItem frm3 = new Form3_AddItem();
            frm3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4_AddOrder frm4 = new Form4_AddOrder();
            frm4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6Bill frm6 = new Form6Bill();
            frm6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5_OderDetails frm5 = new Form5_OderDetails();
            frm5.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            try
            {
                cmdbl = new SqlCommandBuilder(da);
                da.Update(ds, "Cust");
                MessageBox.Show("Information updated", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCust_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgCust.SelectedRows)
            {
               //Accessing cell by indx
                textBox2.Text = row.Cells[1].Value.ToString();
                //Accessing cell by column name
                textBox1.Text = dgCust.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cs.Open();
            DataTable dt = (DataTable)dgCust.DataSource;
            if (dt != null)
                dt.Clear();

            dgCust.Refresh();
            dgCust.Visible = true;
            da2.SelectCommand = new SqlCommand("SELECT OrderID,CID,CustomerName From Customer,[Order] Where CID=@CID and CID=CustomerID", cs);
           
            da2.SelectCommand.Parameters.AddWithValue("@CID", textBox1.Text);
            da2.Fill(ds);
            dgCust.DataSource = ds.Tables[1];
            cs.Close();
            
        }
    }
}
