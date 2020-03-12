using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vipo
{
   

    public partial class gl_in : Form
    {
        SqlConnection connection;

        public gl_in()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312");
            dataGridView1.Refresh();
        }

        private void gl_in_Load(object sender, EventArgs e)
        {
            vishkiTableAdapter.Fill(dubakby_VIPODataSet.vishki);
            plan_agpTableAdapter.Fill(dubakby_VIPODataSet.plan_agp);
            dataGridView1.Refresh();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
        }

        public void addbutton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || String.IsNullOrEmpty(textBox1.Text))
            {
                DialogResult result = MessageBox.Show("Вышка не добавлена!\nПроверьте, все ли значения введены.", "Ошибка добавления", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if (result == DialogResult.Cancel)
                {
                    Close();
                }
            }
            else
            {
                DataRow nRow = dubakby_VIPODataSet.Tables[5].NewRow();
                nRow[0] = textBox1.Text;
                nRow[1] = label5.Text;
                nRow[2] = comboBox2.Text;
                nRow[3] = dateTimePicker1.Text;
                dubakby_VIPODataSet.Tables[5].Rows.Add(nRow);
                plan_agpTableAdapter.Update(dubakby_VIPODataSet.plan_agp);
                dubakby_VIPODataSet.Tables[5].AcceptChanges();
                dataGridView1.Refresh();
                textBox1.Clear();
                plan_agpTableAdapter.Fill(dubakby_VIPODataSet.plan_agp);
            }
        }

        private void progress_button_Click(object sender, EventArgs e)
        {
                progress prog = new progress();
                prog.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {

                    int delet = dataGridView1.SelectedCells[0].RowIndex;
                    dataGridView1.Rows.RemoveAt(delet);
                    plan_agpTableAdapter.Update(dubakby_VIPODataSet);
                }
            }
            catch
            {
                MessageBox.Show("Нельзя удалить запись, т.к. она не выбана");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "INSERT INTO numbers (zav_n, id_v) SELECT zav_n, id_v FROM plan_agp;INSERT INTO plan_all (zav_n, id_v, volt, data_pl, data_v) SELECT zav_n, id_v, volt, data_pl, [data_v] = 0 FROM plan_agp;INSERT INTO progress(zav_n, id_v, id_post, id_op, num_op, op_name, kol_rab, time_norm, proc_op, f_time, otkl) SELECT plan_agp.zav_n, op_norm.id_v, op_norm.id_post, op_norm.id_op, op_norm.num_op, op_norm.op_name, op_norm.kol_rab, op_norm.time_norm, op_norm.proc_op, [f_time] = 0, [otkl] = 0 FROM op_norm INNER JOIN plan_agp ON plan_agp.id_v = op_norm.id_v;TRUNCATE TABLE plan_agp";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = queryString;

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        DialogResult dialogResult = MessageBox.Show("План успешно добавлен!", "Добавление плана", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        plan_agpTableAdapter.Fill(dubakby_VIPODataSet.plan_agp);
                        dataGridView1.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления", "Добавление плана", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        throw;
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
