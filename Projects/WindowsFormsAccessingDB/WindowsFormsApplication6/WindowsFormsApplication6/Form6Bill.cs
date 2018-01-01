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
    public partial class Form6Bill : Form
    {
        public DataSet ds = new DataSet();

        SqlConnection cs = new SqlConnection("Data Source=BILAP84-PC\\V2005;Initial Catalog=Stores2;User ID=sa;Password=sa");

        SqlDataAdapter da = new SqlDataAdapter();
        public Form6Bill()
        {
            InitializeComponent();
            this.Text = "Order Total";
        }

        private void Form6Bill_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgOneOrder.DataSource;
            if (dt != null)
                dt.Clear();
            dgOneOrder.Visible = true;
            //CuName.Enabled = true;
            //OrderTotal.Enabled = true;
            int OrderID = int.Parse(OID.Text);
            int CustomerID = int.Parse(CID.Text);

            cs.Open();
            SqlCommand command = new SqlCommand("SELECT SUM(ItemPrice*Item_Quantity) FROM Item,OrderDetails WHERE( OID=@OID AND ItemID=IID )", cs);

            //Add parameters to Command 1 
            command.Parameters.Add(new SqlParameter("@OID", SqlDbType.Int) { Value = OrderID });
            command.Parameters.Add(new SqlParameter("@CID", SqlDbType.Int) { Value = CustomerID });

            //Put the output in OrderSum
            OrderTotal.Text = command.ExecuteScalar().ToString();
            SqlCommand command2 = new SqlCommand("SELECT CustomerName FROM Customer,OrderDetails WHERE( OID=@OID AND CustomerID=@CID )", cs);
            //Add parameters to Command 2
            command2.Parameters.Add(new SqlParameter("@OID", SqlDbType.Int) { Value = OrderID });
            command2.Parameters.Add(new SqlParameter("@CID", SqlDbType.Int) { Value = CustomerID });


            //Put the output in CustomerName

            CuName.Text = command2.ExecuteScalar().ToString();
            da.SelectCommand = new SqlCommand("SELECT CustomerName,ItemName,Item_Quantity,ItemPrice,ItemPrice*Item_Quantity AS'Total' FROM OrderDetails,Item,Customer WHERE OID=@OID AND CID=@CID And CID=CustomerID and ItemId=IID", cs);
            da.SelectCommand.Parameters.AddWithValue("@OID", OrderID);
            da.SelectCommand.Parameters.AddWithValue("@CID", CustomerID);

            da.Fill(ds);
            dgOneOrder.DataSource = ds.Tables[0];
            cs.Close();
        }
    }
}
