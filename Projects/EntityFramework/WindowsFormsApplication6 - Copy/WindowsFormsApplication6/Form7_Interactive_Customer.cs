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
    public partial class Form7_Interactive_Customer : Form
    {
        public SqlConnection cs;
        public SqlDataAdapter da;
        public SqlCommandBuilder cmdbl;
        public DataSet ds = new DataSet();

        public Form7_Interactive_Customer()
        {
            InitializeComponent();
        }

        private void Form7_Interactive_Customer_Load(object sender, EventArgs e)
        {
           

            cs = new SqlConnection("Data Source=BILAP84-PC\\V2005;Initial Catalog=Stores2;User ID=sa;Password=sa");

            da = new SqlDataAdapter("Select * From Customer", cs);
            da.Fill(ds, "cust");
            dg.DataSource = ds.Tables[0];
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                cmdbl = new SqlCommandBuilder(da);
                da.Update(ds, "Cust");
                MessageBox.Show("Information updated", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
