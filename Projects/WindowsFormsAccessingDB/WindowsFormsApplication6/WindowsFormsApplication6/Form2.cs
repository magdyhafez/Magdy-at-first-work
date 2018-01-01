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
    public partial class Form2 : Form
    {
        public DataSet ds = new DataSet();

        SqlConnection cs = new SqlConnection("Data Source=BILAP84-PC\\V2005;Initial Catalog=Stores2;User ID=sa;Password=sa");

        SqlDataAdapter da = new SqlDataAdapter();

        public Form2()
        {
            InitializeComponent();
            this.Text = "All orders Window";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dg.DataSource;
            if (dt != null)
                dt.Clear();
            dg.Visible = true;
            da.SelectCommand = new SqlCommand("SELECT OID,CID, SUM(ItemPrice*Item_Quantity) AS 'TotalPrice' FROM Item,OrderDetails WHERE( ItemID=IID ) Group by OID,CID ORDER BY OID" , cs);
            da.Fill(ds);
            dg.DataSource = ds.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
