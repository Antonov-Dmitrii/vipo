using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vipo
{
    public partial class UserControl1 : UserControl
    {
        SqlConnection connection;
        DataSet dataSet;
        BindingSource bindingSource;
        DataTable DT;
        public UserControl1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_dmitrii;Password=Qwerty12312");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
