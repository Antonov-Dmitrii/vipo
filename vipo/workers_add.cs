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
    public partial class workers_add : Form
    {
        public workers_add()
        {
            InitializeComponent();
        }

        private void workers_add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dubakby_VIPODataSet.workers);

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
           
            int index = listBox2.FindStringExact(label2.Text, -1);
            if (index != -1)
            {
                MessageBox.Show("Работяга не шали!\n", "Ошибка добавления", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                listBox2.Items.Add(label2.Text);
            } 
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
              vipo_post1 vipo = new vipo_post1();
              int b = Int32.Parse(vipo.kol_rab.Text);
              if (listBox2.Items.Count != b)
              {
                  MessageBox.Show("Норма времени не соответствует выбранному количеству работников!\n", "Ошибка добавления", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
              }
              else
              {

                //vipo.label9.Text = label2.Text;
            }
        }
    }
}
