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
            
            Stores2Entities context = new Stores2Entities();
            int orderNum, CustmerNum;
            orderNum = int.Parse(OID.Text);
            CustmerNum = int.Parse(CID.Text);
            var query = from Customer t in context.Customers
                        join OrderDetail OD in context.OrderDetails
                        on t.CustomerID equals OD.CID  
                        join Customer t2 in context.Customers on t.CustomerID equals CustmerNum
                        select new { t.CustomerName };
           
            foreach (var item in query)
            {
                CuName.Text = item.CustomerName;
                break;   
            }

            //Second way
            var query2 = (from OrderDetail OD in context.OrderDetails

                          join Item I in context.Items on OD.IID equals I.ItemID
                          // join Order O in context.Orders on OD.OID equals O.OrderID
                          where OD.OID == orderNum && OD.CID == CustmerNum
                          // select new {I.ItemPrice,OD.OID,OD.Item_Quantity}

                          group new { OD } by new {OD.OID } into t
                          //  orderby t.Sum(x =>x.I.ItemPrice *x.OD.Item_Quantity)
                          select new
                          {
                              //OrderId = t.Select(x => x.OD.OID),
                             TotalOrder = t.Sum(x =>x.OD.Item_Quantity*x.OD.Item.ItemPrice)
                         }
                         ).ToList();

      
            foreach(var item in query2)
            {
                OrderTotal.Text = item.TotalOrder.ToString();
            }
            ////First attempt

                        ////var query2 = from OrderDetail OD in context.OrderDetails
                        ////             join Item I in context.Items
                        ////             on OD.IID equals I.ItemID
                        ////             join OrderDetail OD2 in context.OrderDetails on OD.OID equals orderNum
                        ////             join OrderDetail OD3 in context.OrderDetails on OD.CID equals CustmerNum
                        ////             select new { I.ItemPrice,OD.Item_Quantity };
                        //var query2 = from OrderDetail OD in context.OrderDetails
                        //             join Item I in context.Items on OD.IID equals I.ItemID
                        //             where OD.OID == orderNum && OD.CID==CustmerNum

                        //             select new { I.ItemPrice, OD.Item_Quantity };

                        //float OT=0;
                        //foreach (var item in query2)
                        //{
                        //    float a = (float)item.ItemPrice;
                        //    float b = (float)item.Item_Quantity;
                        //    OT += a*b;

                        //}
                        //OrderTotal.Text = OT.ToString();

                        // // Coventional way
                        //DataTable dt = (DataTable)dgOneOrder.DataSource;
                        //if (dt != null)
                        //    dt.Clear();
                        //dgOneOrder.Visible = true;
                        ////CuName.Enabled = true;
                        ////OrderTotal.Enabled = true;
                        //int OrderID = int.Parse(OID.Text);
                        //int CustomerID = int.Parse(CID.Text);

                        //cs.Open();
                        //SqlCommand command = new SqlCommand("SELECT SUM(ItemPrice*Item_Quantity) FROM Item,OrderDetails WHERE( OID=@OID AND ItemID=IID )", cs);

                        ////Add parameters to Command 1 
                        //command.Parameters.Add(new SqlParameter("@OID", SqlDbType.Int) { Value = OrderID });
                        //command.Parameters.Add(new SqlParameter("@CID", SqlDbType.Int) { Value = CustomerID });

                        ////Put the output in OrderSum
                        //OrderTotal.Text = command.ExecuteScalar().ToString();
                        //SqlCommand command2 = new SqlCommand("SELECT CustomerName FROM Customer,OrderDetails WHERE( OID=@OID AND CustomerID=@CID )", cs);
                        ////Add parameters to Command 2
                        //command2.Parameters.Add(new SqlParameter("@OID", SqlDbType.Int) { Value = OrderID });
                        //command2.Parameters.Add(new SqlParameter("@CID", SqlDbType.Int) { Value = CustomerID });


                        ////Put the output in CustomerName

                        //CuName.Text = command2.ExecuteScalar().ToString();
                        //da.SelectCommand = new SqlCommand("SELECT CustomerName,ItemName,Item_Quantity,ItemPrice,ItemPrice*Item_Quantity AS'Total' FROM OrderDetails,Item,Customer WHERE OID=@OID AND CID=@CID And CID=CustomerID and ItemId=IID", cs);
                        //da.SelectCommand.Parameters.AddWithValue("@OID", OrderID);
                        //da.SelectCommand.Parameters.AddWithValue("@CID", CustomerID);

                        //da.Fill(ds);
                        //dgOneOrder.DataSource = ds.Tables[0];
                        //cs.Close();
        }
    }
}
