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
using System.Data.SqlClient;

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.vishki". При необходимости она может быть перемещена или удалена.
            this.vishkiTableAdapter.Fill(this.dubakby_VIPODataSet.vishki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.progress". При необходимости она может быть перемещена или удалена.
            this.progressTableAdapter.Fill(this.dubakby_VIPODataSet.progress);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dubakby_VIPODataSet.workers);
            //op_Load();

        }

        /*private void op_Load()
        {
            Convert.ToInt32(label15.Text);
            //int d = Convert.ToInt32(label15.Text);
            //int b = int.Parse(s);
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            //int b = int.Parse(label15.Text);
            string queryString = "SELECT [id_op],[op_name],[kol_rab],[time_norm] FROM [progress] WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [complete] =  0 ;";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connectionString))
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                label8.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "op_name"));
                cmd.Parameters.AddWithValue("@number", label8.Text);
                label5.Text = (cmd.ExecuteScalar().ToString());
                conn.Close();

            }
        }*/
        //  SELECT [id_op],[num_op],[op_name],[kol_rab],[time_norm] FROM [progress] WHERE [zav_n] = '" + label.. + "'  AND [id_v] = '"+ label... + "' AND [id_post] = '" + label... + "' AND [complete] = '" + label... + "' 


        //label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", ds.Tables["QUALITY"], "op_name"));
        /*
                 SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db3;Integrated Security=True");
                 conn.Open();
                 SqlCommand cmd = new SqlCommand("select count (number) from t2 where number=@number", conn); 
                 cmd.Parameters.AddWithValue("@number", label1.Text); 
                 label5.Text=(cmd.ExecuteScalar().ToString()); 
                 conn.Close();
        */


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

        private void button7_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(label15.Text);
            //int d = Convert.ToInt32(label15.Text);
            //int b = int.Parse(s);
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            //int b = int.Parse(label15.Text);
            string queryString = "SELECT [id_op],[op_name],[kol_rab],[time_norm] FROM [progress] WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [complete] =  0 ;";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connectionString))
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                label8.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "op_name"));
                cmd.Parameters.AddWithValue("@number", label8.Text);
                label18.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "id_op"));
                cmd.Parameters.AddWithValue("@number3", label18.Text);
                kol_rab.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "kol_rab"));
                cmd.Parameters.AddWithValue("@number1", kol_rab.Text);
                time_n.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "time_norm"));
                cmd.Parameters.AddWithValue("@number2", time_n.Text);
                label15.Text = (cmd.ExecuteScalar().ToString());
                conn.Close();
            }

            var select = "SELECT [id_v],[id_post],[id_op],[id_mat],[kol_mat],[izm] FROM [mat_norm] WHERE [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + label18.Text + "'  ";
            var c = new SqlConnection(connectionString); 
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter1);
            var dss = new DataSet();
            dataAdapter1.Fill(dss);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dss.Tables[0];


            SqlConnection Con = new SqlConnection(connectionString); //Новое подключение
            SqlCommand command = new SqlCommand("SELECT [rab_name] FROM [workers] WHERE [id_post] = '" + label15.Text + "' ", Con); //Команда выбора данных
            Con.Open(); //Открываем соединение
            SqlDataReader read = command.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                listBox1.Items.Add(read.GetValue(0).ToString()); //Добавляем данные в лист итем
            }
            Con.Close();
        }
    }
}
