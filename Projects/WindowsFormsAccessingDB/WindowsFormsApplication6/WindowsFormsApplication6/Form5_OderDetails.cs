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
    public partial class Form5_OderDetails : Form
    {
        public DataSet ds = new DataSet();

        SqlConnection cs = new SqlConnection("Data Source=BILAP84-PC\\V2005;Initial Catalog=Stores2;User ID=sa;Password=sa");

        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommandBuilder cmdbl;

        public Form5_OderDetails()
        {
            InitializeComponent();
            this.Text = "Order Detail Window";
        }

        private void Form5_OderDetails_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgOrderDetails.DataSource;
            if (dt != null)
                dt.Clear();
            dgOrderDetails.Visible = true;
            da.SelectCommand = new SqlCommand("SELECT OID,CID,CustomerName,ItemName,Item_Quantity FROM OrderDetails,Customer,Item Where IID=ItemID AND CustomerId=CID ", cs);
            da.Fill(ds,"OD");
            dgOrderDetails.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            da.InsertCommand = new SqlCommand("INSERT INTO OrderDetails VALUES (@OID,@CID,@IID,@IQ)", cs);
            da.InsertCommand.Parameters.Add("@OID", SqlDbType.Int).Value = int.Parse(OID.Text);
            da.InsertCommand.Parameters.Add("@CID", SqlDbType.Int).Value = int.Parse(CID.Text);
            da.InsertCommand.Parameters.Add("@IID", SqlDbType.Float).Value = float.Parse(IID.Text);
            da.InsertCommand.Parameters.Add("@IQ", SqlDbType.Int).Value = int.Parse(IQ.Text);

            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
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
                da.Update(ds, "OD");
                MessageBox.Show("Information updated", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
