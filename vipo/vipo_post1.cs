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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet1.op_norm". При необходимости она может быть перемещена или удалена.
            this.op_normTableAdapter.Fill(this.dubakby_VIPODataSet1.op_norm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.dubakby_VIPODataSet.materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.mat_norm". При необходимости она может быть перемещена или удалена.
            this.mat_normTableAdapter.Fill(this.dubakby_VIPODataSet.mat_norm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.vishki". При необходимости она может быть перемещена или удалена.
            this.vishkiTableAdapter.Fill(this.dubakby_VIPODataSet.vishki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.progress". При необходимости она может быть перемещена или удалена.
            this.progressTableAdapter.Fill(this.dubakby_VIPODataSet.progress);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dubakby_VIPODataSet.workers);
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            StartTime = DateTime.Now;
            

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

            if (label10.Visible == true)
            {
                string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                SqlConnection connect = new SqlConnection(connection);
                string sql = "INSERT zp (rab_name , zav_n , id_v, id_post, id_op, stavka, time_norm, op_end ) VALUES (@rab_name ,@zav_n ,@id_v ,@id_post , @id_op ,@id_st , @time_norm ,@op_end )";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@rab_name", label10.Text);
                cmd_SQL.Parameters.AddWithValue("@zav_n", label6.Text);
                cmd_SQL.Parameters.AddWithValue("@id_v", label16.Text);
                cmd_SQL.Parameters.AddWithValue("@id_post", label15.Text);
                cmd_SQL.Parameters.AddWithValue("@id_op", label18.Text);
                cmd_SQL.Parameters.AddWithValue("@id_st", label20.Text);
                cmd_SQL.Parameters.AddWithValue("@time_norm", time_n.Text);
                cmd_SQL.Parameters.AddWithValue("@op_end",label21.Text);
               // cmd_SQL.Parameters.AddWithValue("@f_time", time_f.Text);
                try
                {
                    connect.Open();
                    
                  int n = cmd_SQL.ExecuteNonQuery();
                    //Convert.ToString(n);
                    //MessageBox.Show("Добавлено {0} записей", n);
                }
                catch (SqlException ex)
                {
                     throw new ApplicationException("error insert new_tovar", ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            //////////////////////////////////////////////////
       
            if (label11.Visible == true)
            {
                string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                SqlConnection connect = new SqlConnection(connection);
                string sql = "INSERT zp (id_rab , zav_n , id_v, id_post, id_op, id_st, time_norm, op_end , f_time) VALUES (@id_rab ,@zav_n ,@id_v ,@id_post , @id_op ,@id_st , @time_norm ,@op_end ,@f_time)";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@rab_name", label11.Text);
                cmd_SQL.Parameters.AddWithValue("@zav_n", label6.Text);
                cmd_SQL.Parameters.AddWithValue("@id_v", label4.Text);
                cmd_SQL.Parameters.AddWithValue("@id_post", label15.Text);
                cmd_SQL.Parameters.AddWithValue("@id_op", label18.Text);
                // cmd_SQL.Parameters.AddWithValue("@id_st", time_n.Text);
                cmd_SQL.Parameters.AddWithValue("@time_norm", time_n.Text);
                // cmd_SQL.Parameters.AddWithValue("@op_end", tbNameTov.Text);
                cmd_SQL.Parameters.AddWithValue("@f_time", time_f.Text);
                try
                {
                    connect.Open();
                    int n = cmd_SQL.ExecuteNonQuery();
                    // lbl_Delete.Text += String.Format("Добавлено {0} записей", n);
                }
                catch (SqlException ex)
                {
                    // throw new ApplicationException("error insert new_tovar", ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            /////////////////////////////////////////////////
            
            if (label12.Visible == true)
            {
                string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                SqlConnection connect = new SqlConnection(connection);
                string sql = "INSERT zp (id_rab , zav_n , id_v, id_post, id_op, id_st, time_norm, op_end , f_time) VALUES (@id_rab ,@zav_n ,@id_v ,@id_post , @id_op ,@id_st , @time_norm ,@op_end ,@f_time)";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@rab_name", label12.Text);
                cmd_SQL.Parameters.AddWithValue("@zav_n", label6.Text);
                cmd_SQL.Parameters.AddWithValue("@id_v", label4.Text);
                cmd_SQL.Parameters.AddWithValue("@id_post", label15.Text);
                cmd_SQL.Parameters.AddWithValue("@id_op", label18.Text);
                // cmd_SQL.Parameters.AddWithValue("@id_st", time_n.Text);
                cmd_SQL.Parameters.AddWithValue("@time_norm", time_n.Text);
                // cmd_SQL.Parameters.AddWithValue("@op_end", tbNameTov.Text);
                cmd_SQL.Parameters.AddWithValue("@f_time", time_f.Text);
                try
                {
                    connect.Open();
                    int n = cmd_SQL.ExecuteNonQuery();
                    // lbl_Delete.Text += String.Format("Добавлено {0} записей", n);
                }
                catch (SqlException ex)
                {
                    // throw new ApplicationException("error insert new_tovar", ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            //////////////////////////////////////////////////////////////

            if (label13.Visible == true)
            {
                string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                SqlConnection connect = new SqlConnection(connection);
                string sql = "INSERT zp (id_rab , zav_n , id_v, id_post, id_op, id_st, time_norm, op_end , f_time) VALUES (@id_rab ,@zav_n ,@id_v ,@id_post , @id_op ,@id_st , @time_norm ,@op_end ,@f_time)";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@rab_name", label13.Text);
                cmd_SQL.Parameters.AddWithValue("@zav_n", label6.Text);
                cmd_SQL.Parameters.AddWithValue("@id_v", label4.Text);
                cmd_SQL.Parameters.AddWithValue("@id_post", label15.Text);
                cmd_SQL.Parameters.AddWithValue("@id_op", label18.Text);
                // cmd_SQL.Parameters.AddWithValue("@id_st", time_n.Text);
                cmd_SQL.Parameters.AddWithValue("@time_norm", time_n.Text);
                // cmd_SQL.Parameters.AddWithValue("@op_end", tbNameTov.Text);
                cmd_SQL.Parameters.AddWithValue("@f_time", time_f.Text);
                try
                {
                    connect.Open();
                    int n = cmd_SQL.ExecuteNonQuery();
                    // lbl_Delete.Text += String.Format("Добавлено {0} записей", n);
                }
                catch (SqlException ex)
                {
                    // throw new ApplicationException("error insert new_tovar", ex);
                }
                finally
                {
                    connect.Close();
                }
            }

        }
        private DateTime StartTime;
        public void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;

            // Начнем с дней, если больше 0.
            string text = "";
            if (elapsed.Days > 0)
                text += elapsed.Days.ToString() + ".";

            // Преобразование миллисекунд в десятые доли секунды.
            int tenths = elapsed.Milliseconds / 100;

            // Запишите оставшееся время.
            text +=
                elapsed.Hours.ToString("00") + ":" +
                elapsed.Minutes.ToString("00") + ":" +
                elapsed.Seconds.ToString("00") + "." +
                tenths.ToString("0");

            time_f.Text = text;
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
            label9.Text = listBox1.SelectedItem.ToString();
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
            pictureBox1.Visible = true;
            dataGridView1.Visible = true;
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
                kol_rab.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "kol_rab"));
                cmd.Parameters.AddWithValue("@number1", kol_rab.Text);
                time_n.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "time_norm"));
                cmd.Parameters.AddWithValue("@number2", time_n.Text);
                label18.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "id_op"));
                cmd.Parameters.AddWithValue("@number3", label18.Text);
                label15.Text = (cmd.ExecuteScalar().ToString());
                conn.Close();
            }

           var select = "SELECT [id_v],[id_post],[id_op],[id_mat],[kol_mat],[izm] FROM [mat_norm] WHERE [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + label18.Text + "'";
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

            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////

            string connectionString2 = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString2 = "SELECT stavka FROM [stavka] WHERE [id_post] = '" + label15.Text + "' ";
            using (SqlDataAdapter dataAdapter2 = new SqlDataAdapter(queryString2, connectionString2))
            {
                DataSet ds2 = new DataSet();
                SqlConnection conn2 = new SqlConnection(connectionString2);
                conn2.Open();
                SqlCommand cmd = new SqlCommand(queryString2, conn2);
                label20.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["stavka"], "stavka"));
                cmd.Parameters.AddWithValue("@number5", label20.Text);
                label20.Text = (cmd.ExecuteScalar().ToString());
                conn2.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label21.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
