using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            dgOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (Stores2Entities context = new Stores2Entities())
            {
                Order or = new Order();
                or.OrderID = int.Parse(OID.Text);
                or.CID = int.Parse(CID.Text);
                context.Orders.Add(or);
                context.SaveChanges();
            }


              
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Stores2Entities context = new Stores2Entities();
            var query = from Order in context.Orders
                       

                        select new
                        {
                           Order.OrderID,Order.CID

                        };
            dgOrder.Visible = true;

            dgOrder.DataSource = query.ToList();


            //    DataTable dt = (DataTable)dgOrder.DataSource;
            //    if (dt != null)
            //        dt.Clear();
            //    dgOrder.Visible = true;
            //    //cs.Open();
            //    da.SelectCommand = new SqlCommand("SELECT * FROM [Order]", cs);
            //    da.Fill(ds,"O");
            //    dgOrder.DataSource = ds.Tables[0];
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
            using (Stores2Entities context = new Stores2Entities())
            {
                int ID = int.Parse(OID.Text);
                Order o = context.Orders.FirstOrDefault(c => c.OrderID == ID);
                
                o.CID = int.Parse(CID.Text);

                context.SaveChanges();
                button4_Click(sender, e);
            }
        }

        private void dgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgOrder.SelectedRows)
            {
                //Accessing cell by indx
                CID.Text = row.Cells[1].Value.ToString();
                
                OID.Text = row.Cells[0].Value.ToString();

            }
        }
    }
    }

