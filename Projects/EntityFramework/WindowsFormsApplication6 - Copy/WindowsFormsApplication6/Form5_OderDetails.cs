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
            dgOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stores2Entities context = new Stores2Entities();
            var query = from OrderDetail in context.OrderDetails
                        join Customer in context.Customers on OrderDetail.CID equals Customer.CustomerID
                        join Item in context.Items on OrderDetail.IID equals Item.ItemID
                        

                        select new
                        {
                            OrderDetail.OID,OrderDetail.CID,Customer.CustomerName,OrderDetail.IID,Item.ItemName,
                            OrderDetail.Item_Quantity
                        };
            dgOrderDetails.Visible = true;

            dgOrderDetails.DataSource = query.ToList();

            //DataTable dt = (DataTable)dgOrderDetails.DataSource;
            //if (dt != null)
            //    dt.Clear();
            //dgOrderDetails.Visible = true;
            //da.SelectCommand = new SqlCommand("SELECT OID,CID,CustomerName,ItemName,Item_Quantity FROM OrderDetails,Customer,Item Where IID=ItemID AND CustomerId=CID ", cs);
            //da.Fill(ds,"OD");
            //dgOrderDetails.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Stores2Entities context = new Stores2Entities())
            {
                OrderDetail od = new OrderDetail();
                od.IID = int.Parse(IID.Text);
                od.OID= int.Parse(OID.Text);
                od.CID= int.Parse(CID.Text);
                od.Item_Quantity= int.Parse(IQ.Text);
                context.OrderDetails.Add(od);
                context.SaveChanges();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Stores2Entities context = new Stores2Entities())
            {
                int ID = int.Parse(OID.Text);
                int cid= int.Parse(CID.Text);
                int iid = int.Parse(IID.Text);
                OrderDetail od = context.OrderDetails.FirstOrDefault(c =>( (c.OID == ID)&&(c.CID==cid)&&(c.IID==iid)) );

               
                od.Item_Quantity = int.Parse(IQ.Text);

                context.SaveChanges();
                button4_Click(sender, e);
            }
        }

        private void dgOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgOrderDetails.SelectedRows)
            {
                //Accessing cell by indx
              OID.Text = row.Cells[0].Value.ToString();

                CID.Text = row.Cells[1].Value.ToString();
                IID.Text = row.Cells[3].Value.ToString();
                IQ.Text = row.Cells[5].Value.ToString();




            }
        }
    }
}
