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
    public partial class vipo_post1 : Form
    {
        int i;
        int tk;
        string c;

        public vipo_post1()
        {
            InitializeComponent();
          
            timer1.Interval = 1000; //интервал между срабатываниями 1000 миллисекунд
           // timer.Tick += new EventHandler(timer_Tick); //подписываемся на события Tick

        }

       

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void vipo_post1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dubakby_VIPODataSet.workers);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            c = "00:00";

            
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            tk = ++i;
            TimeSpan span = TimeSpan.FromMinutes(tk);
            string time_n = span.ToString(@"hh\:mm");
            time_f.Text = time_n.ToString(); 
        }
    }
}
