using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

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

        private void button1_Click(object sender, EventArgs e)
        {   //timer
            i = 0;
            c = "00:00";
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            /////////////////////////////////////////
            ////////////////////////////////////////
            
            if (listBox2.Items.Count == 1)
            {
                label10.Visible = true;
                label10.Text = listBox2.Items[0].ToString();

            }
            if (listBox2.Items.Count == 2)
            {
                label10.Visible = true;
                label11.Visible = true;
                label10.Text = listBox2.Items[0].ToString();
                label11.Text = listBox2.Items[1].ToString();

            }
            if (listBox2.Items.Count == 3)
            {
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label10.Text = listBox2.Items[0].ToString();
                label11.Text = listBox2.Items[1].ToString();
                label12.Text = listBox2.Items[2].ToString();

            }
            if (listBox2.Items.Count == 4)
            {
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label10.Text = listBox2.Items[0].ToString();
                label11.Text = listBox2.Items[1].ToString();
                label12.Text = listBox2.Items[2].ToString();
                label13.Text = listBox2.Items[3].ToString();
            }

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

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void listBox1_DoubleClick_1(object sender, EventArgs e)
        {
            int b = Int32.Parse(kol_rab.Text);
            int index = listBox2.FindStringExact(label9.Text, -1);
            if (index != -1)
            {
                MessageBox.Show("Работяга не шали!\n", "Ошибка добавления", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (listBox2.Items.Count != b)
            {
                listBox2.Items.Add(label9.Text);
            }
            else
            {
                MessageBox.Show("Норма времени не соответствует выбранному количеству работников!\n", "Ошибка добавления", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void listBox2_DoubleClick_1(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}
