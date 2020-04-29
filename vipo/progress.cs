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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.zp". При необходимости она может быть перемещена или удалена.
            this.zpTableAdapter.Fill(this.dubakby_VIPODataSet.zp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.p_time". При необходимости она может быть перемещена или удалена.
            this.p_timeTableAdapter.Fill(this.dubakby_VIPODataSet.p_time);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.progress". При необходимости она может быть перемещена или удалена.
            this.progressTableAdapter.Fill(this.dubakby_VIPODataSet.progress);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.plan_all". При необходимости она может быть перемещена или удалена.
            this.plan_allTableAdapter.Fill(this.dubakby_VIPODataSet.plan_all);
           
        }

        
    }
}
