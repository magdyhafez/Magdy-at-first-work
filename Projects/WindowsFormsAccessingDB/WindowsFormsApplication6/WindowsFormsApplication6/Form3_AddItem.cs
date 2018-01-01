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

    public partial class Form3_AddItem : Form
    {
        public DataSet ds = new DataSet();

        SqlConnection cs = new SqlConnection("Data Source=BILAP84-PC\\V2005;Initial Catalog=Stores2;User ID=sa;Password=sa");

        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommandBuilder cmdbl;
        public Form3_AddItem()
        {
            InitializeComponent();
            this.Text = "Items Window";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_AddItem_Load(object sender, EventArgs e)
        {
            dgItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgItem.DataSource;
            if (dt != null)
                dt.Clear();
            dgItem.Visible = true;
            da.SelectCommand = new SqlCommand("SELECT* FROM Item", cs);
            da.Fill(ds,"I");
            dgItem.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            da.InsertCommand = new SqlCommand("INSERT INTO Item VALUES (@IID,@INAME,@IPRICE)", cs);
            da.InsertCommand.Parameters.Add("@IID", SqlDbType.Int).Value = int.Parse(IID.Text);
            da.InsertCommand.Parameters.Add("@INAME", SqlDbType.VarChar).Value = INAME.Text;
            da.InsertCommand.Parameters.Add("@IPRICE", SqlDbType.Float).Value = float.Parse(IPRICETXT.Text);

            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
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

        private void dgItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IPRICE_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmdbl = new SqlCommandBuilder(da);
                da.Update(ds, "I");
                MessageBox.Show("Information updated", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow row in dgItem.SelectedRows)
            {
                IID.Text = row.Cells[0].Value.ToString();
                INAME.Text = row.Cells[1].Value.ToString();
                IPRICETXT.Text= row.Cells[2].Value.ToString();

            }
        }
    }
}
