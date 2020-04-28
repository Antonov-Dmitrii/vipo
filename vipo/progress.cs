using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vipo
{
    public partial class progress : Form
    {
        public progress()
        {
            InitializeComponent();
        }

        private void progress_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.plan_all". При необходимости она может быть перемещена или удалена.
            this.plan_allTableAdapter.Fill(this.dubakby_VIPODataSet.plan_all);
           
        }

        
    }
}
