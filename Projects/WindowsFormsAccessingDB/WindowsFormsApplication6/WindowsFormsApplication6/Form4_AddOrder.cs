using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form4_AddOrder : Form
    {
        public DataSet ds = new DataSet();

        SqlConnection cs = new SqlConnection("Data Source=BILAP84-PC\\V2005;Initial Catalog=Stores2;User ID=sa;Password=sa");

        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommandBuilder cmdbl;
        public Form4_AddOrder()
        {
            InitializeComponent();
            this.Text = "Order Window";
        }

        private void Form4_AddOrder_Load(object sender, EventArgs e)
        {
}

        private void button3_Click(object sender, EventArgs e)
        {
            da.InsertCommand = new SqlCommand("INSERT INTO [Order] VALUES (@OID,@CID)", cs);
            da.InsertCommand.Parameters.Add("@OID", SqlDbType.Int).Value = int.Parse(OID.Text);
            da.InsertCommand.Parameters.Add("@CID", SqlDbType.VarChar).Value = int.Parse(CID.Text);


            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgOrder.DataSource;
            if (dt != null)
                dt.Clear();
            dgOrder.Visible = true;
            //cs.Open();
            da.SelectCommand = new SqlCommand("SELECT * FROM [Order]", cs);
            da.Fill(ds,"O");
            dgOrder.DataSource = ds.Tables[0];
           // cs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5_OderDetails frm5 = new Form5_OderDetails();
            frm5.Show();
        }

        private void dgOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void INAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void IID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                cmdbl = new SqlCommandBuilder(da);
                da.Update(ds, "O");
                MessageBox.Show("Information updated", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
