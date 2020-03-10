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

namespace vipo
{
    public partial class bu_otchet : Form
    {
        //работа с БД
/*        private readonly IDataContext _dataContext = new TestDataContext();
        //источник привязки для DGV
        private readonly BindingSource _bsPeople = new BindingSource();
        //объект формирования выборок для DGV
        private readonly FilterDgv _filterDgv = new FilterDgv();*/
        SqlConnection connection_bu;
        DataSet dataSet_bu;
        BindingSource bindingSource;
        DataTable dt_bu;
        SqlDataAdapter da_bu;
        BindingSource bs_bu;

        public bu_otchet()
        {
            InitializeComponent();
            connection_bu = new SqlConnection(@"Data Source=93.125.99.108;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312");
            dataSet_bu = new DataSet();
        }

            private void bu_otchet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.dubakby_VIPODataSet.posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.dubakby_VIPODataSet.sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.dubakby_VIPODataSet.materials);
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                skladBindingSource.Filter = "";
            else skladBindingSource.Filter = string.Format("kol=0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label12.Text))
            {
                MessageBox.Show("Выберите материал!");
            }
            else
            {
                string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                _ = int.Parse(label12.Text);
                string queryString1 = "INSERT INTO sklad (id_mat, id_post, kol, izm) VALUES ('" + label12.Text + "', '" + comboBox1.Text + "', '" + textBox1.Text + "', '" + label14.Text.ToString() + "');";       
                 
                using (SqlConnection connection_bu = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection_bu.CreateCommand())
                    {
                        command.CommandText = queryString1;

                        try
                        {
                            connection_bu.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Материал " + label13.Text + " добавлен на ПОСТ №" + comboBox1.Text + " в количестве " + textBox1.Text +" "+ label14.Text +".");
                            skladTableAdapter.Fill(dubakby_VIPODataSet.sklad);
                            dataGridView1.Refresh();
                            textBox1.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка добавления");
                            throw;
                        }
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
                materialsBindingSource.Filter = "";
            else materialsBindingSource.Filter = String.Format("mat_name LIKE '%{0}%'", textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
                skladBindingSource.Filter = "";
            else
                skladBindingSource.Filter = string.Format("[id_post] = {0}", textBox3.Text);
        }

        private void dgv_materials_Click(object sender, EventArgs e)
        {
            String s = dgv_materials.CurrentRow.Cells[0].Value.ToString();
            label12.Text = s;
            //int i = int.Parse(label12.Text);
            String s1 = dgv_materials.CurrentRow.Cells[1].Value.ToString();
            label13.Text = s1;
            String s2 = dgv_materials.CurrentRow.Cells[2].Value.ToString();
            label14.Text = s2;

        }
    }
}