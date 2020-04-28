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
    public partial class vipo_post : Form
    {

        public vipo_post()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;
            notifyIcon1.Click += notifyIcon1_Click;

            // задаем иконку всплывающей подсказки
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            // задаем текст подсказки
            notifyIcon1.BalloonTipText = "Нажмите, чтобы отобразить окно";
            // устанавливаем зголовк
            notifyIcon1.BalloonTipTitle = "Подсказка";
            // отображаем подсказку 12 секунд
            notifyIcon1.ShowBalloonTip(12);

        }

        int h, m, s; //часы, минуты, секунды
        string zav_n1, id_v1, id_post1, id_op1, op_name1, v_name1, h1, m1, s1;
        int MyForm;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            h = Convert.ToInt32(time_f.Text);
            m = Convert.ToInt32(time_f1.Text);
            s = Convert.ToInt32(time_f2.Text);
            timer1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void vipo_post1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.p_time". При необходимости она может быть перемещена или удалена.
            this.p_timeTableAdapter1.Fill(this.dubakby_VIPODataSet.p_time);
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dubakby_VIPODataSet.workers);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox3.Enabled = true;
            pictureBox2.Enabled = false;
            button7.Enabled = false;
            button5.Enabled = false;
            h = 0;
            m = 0;
            s = 0;
            spisanie_mat();
            time();
            timer1.Enabled = true;
            timer1.Start();

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
            rab_start();
            button1.Enabled = false;
        }

        private void spisanie_mat()
        {
            // SqlCommand cmd = new SqlCommand("UPDATE sklad SET sklad.kol = sklad.kol - (Select kol_mat FROM mat_norm WHERE [sklad].[id_mat] = [mat_norm].[id_mat] AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "')", con);
            SqlConnection con = new SqlConnection("Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
             SqlCommand cmd = new SqlCommand("UPDATE sklad SET sklad.kol = sklad.kol - m.kol_mat FROM mat_norm AS m WHERE sklad.id_mat = m.id_mat AND sklad.id_mat = '" + dataGridView1.Rows[i].Cells[0].Value + "' AND sklad.id_v = '" + label16.Text + "'", con);// AND sklad.id_post = '" + label15.Text + "'

                try           
            {
                con.Open();
                    skladTableAdapter.Update(dubakby_VIPODataSet.sklad);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("error insert sklad", ex);
                }
                finally
                {
                    con.Close();
                }
           }
        }

        private void rab_start()
        {
            if (label10.Visible == true)
            {
                string st = stavka.Text;
                float st1 = float.Parse(st);
                string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                SqlConnection connect = new SqlConnection(connection);
                string sql = "INSERT zp (rab_name , zav_n , id_v, id_post, id_op, stavka, time_norm, op_start ) VALUES (@rab_name ,@zav_n ,@id_v ,@id_post , @id_op ,@stavka , @time_norm ,@op_start )";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@rab_name", label10.Text);
                cmd_SQL.Parameters.AddWithValue("@zav_n", label6.Text);
                cmd_SQL.Parameters.AddWithValue("@id_v", label16.Text);
                cmd_SQL.Parameters.AddWithValue("@id_post", label15.Text);
                cmd_SQL.Parameters.AddWithValue("@id_op", id_op.Text);
                cmd_SQL.Parameters.AddWithValue("@stavka", st1);
                cmd_SQL.Parameters.AddWithValue("@time_norm", time_n.Text);
                cmd_SQL.Parameters.AddWithValue("@op_start", dateTimePicker1.Value);

                try
                {
                    connect.Open();
                    zpTableAdapter.Update(dubakby_VIPODataSet.zp);
                    cmd_SQL.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    throw new ApplicationException("error insert zp", ex);

                }
                finally
                {
                    connect.Close();
                }
            }

            if (label11.Visible == true)
            {
                string st = stavka.Text;
                float st1 = float.Parse(st);
                string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                SqlConnection connect = new SqlConnection(connection);
                string sql = "INSERT zp (rab_name , zav_n , id_v, id_post, id_op, stavka, time_norm, op_start ) VALUES (@rab_name ,@zav_n ,@id_v ,@id_post , @id_op ,@stavka , @time_norm ,@op_start )";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@rab_name", label11.Text);
                cmd_SQL.Parameters.AddWithValue("@zav_n", label6.Text);
                cmd_SQL.Parameters.AddWithValue("@id_v", label16.Text);
                cmd_SQL.Parameters.AddWithValue("@id_post", label15.Text);
                cmd_SQL.Parameters.AddWithValue("@id_op", id_op.Text);
                cmd_SQL.Parameters.AddWithValue("@stavka", st1);
                cmd_SQL.Parameters.AddWithValue("@time_norm", time_n.Text);
                cmd_SQL.Parameters.AddWithValue("@op_start", dateTimePicker1.Value);

                try
                {
                    connect.Open();
                    zpTableAdapter.Update(dubakby_VIPODataSet.zp);
                    cmd_SQL.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    throw new ApplicationException("error insert zp", ex);

                }
                finally
                {
                    connect.Close();
                }
            }

            if (label12.Visible == true)
            {
                string st = stavka.Text;
                float st1 = float.Parse(st);
                string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                SqlConnection connect = new SqlConnection(connection);
                string sql = "INSERT zp (rab_name , zav_n , id_v, id_post, id_op, stavka, time_norm, op_start ) VALUES (@rab_name ,@zav_n ,@id_v ,@id_post , @id_op ,@stavka , @time_norm ,@op_start )";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@rab_name", label12.Text);
                cmd_SQL.Parameters.AddWithValue("@zav_n", label6.Text);
                cmd_SQL.Parameters.AddWithValue("@id_v", label16.Text);
                cmd_SQL.Parameters.AddWithValue("@id_post", label15.Text);
                cmd_SQL.Parameters.AddWithValue("@id_op", id_op.Text);
                cmd_SQL.Parameters.AddWithValue("@stavka", st1);
                cmd_SQL.Parameters.AddWithValue("@time_norm", time_n.Text);
                cmd_SQL.Parameters.AddWithValue("@op_start", dateTimePicker1.Value);

                try
                {
                    connect.Open();
                    zpTableAdapter.Update(dubakby_VIPODataSet.zp);
                    cmd_SQL.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    throw new ApplicationException("error insert zp", ex);

                }
                finally
                {
                    connect.Close();
                }
            }

            if (label13.Visible == true)
            {
                string st = stavka.Text;
                float st1 = float.Parse(st);
                string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                SqlConnection connect = new SqlConnection(connection);
                string sql = "INSERT zp (rab_name , zav_n , id_v, id_post, id_op, stavka, time_norm, op_start ) VALUES (@rab_name ,@zav_n ,@id_v ,@id_post , @id_op ,@stavka , @time_norm ,@op_start )";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@rab_name", label13.Text);
                cmd_SQL.Parameters.AddWithValue("@zav_n", label6.Text);
                cmd_SQL.Parameters.AddWithValue("@id_v", label16.Text);
                cmd_SQL.Parameters.AddWithValue("@id_post", label15.Text);
                cmd_SQL.Parameters.AddWithValue("@id_op", id_op.Text);
                cmd_SQL.Parameters.AddWithValue("@stavka", st1);
                cmd_SQL.Parameters.AddWithValue("@time_norm", time_n.Text);
                cmd_SQL.Parameters.AddWithValue("@op_start", dateTimePicker1.Value);

                try
                {
                    connect.Open();
                    zpTableAdapter.Update(dubakby_VIPODataSet.zp);
                    cmd_SQL.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    throw new ApplicationException("error insert zp", ex);

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void time()
        {
            string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            SqlConnection connect = new SqlConnection(connection);
            string sql = "INSERT p_time (zav_n , id_v, id_post, id_op, op_start, time_norm) VALUES (@zav_n ,@id_v ,@id_post , @id_op, @op_start, @time_norm)";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            cmd_SQL.Parameters.AddWithValue("@zav_n", label6.Text);
            cmd_SQL.Parameters.AddWithValue("@id_v", label16.Text);
            cmd_SQL.Parameters.AddWithValue("@id_post", label15.Text);
            cmd_SQL.Parameters.AddWithValue("@id_op", id_op.Text);
            cmd_SQL.Parameters.AddWithValue("@op_start", dateTimePicker1.Value);
            cmd_SQL.Parameters.AddWithValue("@time_norm", time_n.Text);

            try
            {
                connect.Open();
                p_timeTableAdapter.Update(dubakby_VIPODataSet.zp);
                cmd_SQL.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw new ApplicationException("error insert p_time", ex);

            }
            finally
            {
                connect.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            button5.Enabled = true;
            pictureBox2.Enabled = true;
            int h = Int32.Parse(time_f.Text);
            int m = Int32.Parse(time_f1.Text);
            int s = Int32.Parse(time_f2.Text);
            timer1.Stop(); // при нажатии пользователем на кнопку "Стоп" таймер останавливается
            int d = (h * 60) + m + (s / 60);
            string dd = Convert.ToString(d);
            label18.Text = dd;
            timer1.Enabled = false;
            time_f.Text = "00";
            time_f1.Text = "00";
            time_f2.Text = "00";
            
            op_end();
            rab_vremya();
            complete_method();
        }

        private void op_end()
        {
            string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            SqlConnection connect = new SqlConnection(connection);
            string sql = "UPDATE p_time SET op_end = @op_end, f_time=@f_time WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + id_op.Text + "'";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            cmd_SQL.Parameters.AddWithValue("@op_end", dateTimePicker1.Value);
            cmd_SQL.Parameters.AddWithValue("@f_time", label18.Text);

            try
            {
                connect.Open();
                p_timeTableAdapter.Update(dubakby_VIPODataSet.zp);
                cmd_SQL.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw new ApplicationException("error insert p_time", ex);

            }
            finally
            {
                connect.Close();
            }
        }

        private void rab_vremya()
        {
            if (label10.Visible == true)
            {
                string st = stavka.Text;
                float st1 = float.Parse(st);
                string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                SqlConnection connect = new SqlConnection(connection);
                string sql = "UPDATE zp SET op_end = @op_end WHERE [rab_name] = '" + label10.Text + "' AND [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + id_op.Text + "'";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@op_end", dateTimePicker1.Value);

                try
                {
                    connect.Open();
                    zpTableAdapter.Update(dubakby_VIPODataSet.zp);
                    cmd_SQL.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    throw new ApplicationException("error insert zp", ex);

                }
                finally
                {
                    connect.Close();
                }
            }

            if (label11.Visible == true)
            {
                string st = stavka.Text;
                float st1 = float.Parse(st);
                string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                SqlConnection connect = new SqlConnection(connection);
                string sql = "UPDATE zp SET op_end = @op_end WHERE [rab_name] = '" + label11.Text + "' AND [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + id_op.Text + "'";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@op_end", dateTimePicker1.Value);

                try
                {
                    connect.Open();
                    zpTableAdapter.Update(dubakby_VIPODataSet.zp);
                    cmd_SQL.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    throw new ApplicationException("error insert zp", ex);

                }
                finally
                {
                    connect.Close();
                }
            }

            if (label12.Visible == true)
            {
                string st = stavka.Text;
                float st1 = float.Parse(st);
                string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                SqlConnection connect = new SqlConnection(connection);
                string sql = "UPDATE zp SET op_end = @op_end WHERE [rab_name] = '" + label12.Text + "' AND [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + id_op.Text + "'";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@op_end", dateTimePicker1.Value);

                try
                {
                    connect.Open();
                    zpTableAdapter.Update(dubakby_VIPODataSet.zp);
                    cmd_SQL.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    throw new ApplicationException("error insert zp", ex);

                }
                finally
                {
                    connect.Close();
                }
            }

            if (label13.Visible == true)
            {
                string st = stavka.Text;
                float st1 = float.Parse(st);
                string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                SqlConnection connect = new SqlConnection(connection);
                string sql = "UPDATE zp SET op_end = @op_end WHERE [rab_name] = '" + label13.Text + "' AND [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + id_op.Text + "'";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@op_end", dateTimePicker1.Value);

                try
                {
                    connect.Open();
                    zpTableAdapter.Update(dubakby_VIPODataSet.zp);
                    cmd_SQL.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    throw new ApplicationException("error insert zp", ex);

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            s = s + 1; //каждую секунду счетчик таймера секунд уменьшается на 1
            if (s == 60) //если кончается минута, а секундная переменная становится меньше единицы, значит минута уменьшается на единицу, а секундный счетчик начинает с 59
            {
                m = m + 1;
                s = 0;
            }
            if (m == 60) //то же самое для часов
            {
                h = h + 1;
                m = 0;
            }

            time_f.Text = Convert.ToString(h); //выводим таймер на экран, чтобы пользователь наглядно видел, сколько время осталось.
            time_f1.Text = Convert.ToString(m);
            time_f2.Text = Convert.ToString(s);

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
                groupBox2.Visible = true;
                button1.Enabled = true;
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
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            id_op.DataBindings.Clear();
            op_name_label.DataBindings.Clear();
            time_n.DataBindings.Clear();
            kol_rab.DataBindings.Clear();
            stavka.DataBindings.Clear();
            time_f.DataBindings.Clear();
            time_f1.DataBindings.Clear();
            time_f2.DataBindings.Clear();
            label10.DataBindings.Clear();
            label11.DataBindings.Clear();
            label12.DataBindings.Clear();
            label13.DataBindings.Clear();
            groupBox1.Visible = true;
            op_name_label.Visible = true;
            button5.Visible = true;
            op_name_method();
            id_op_method();
            kol_rab_method();
            time_norm_method();
            img_method();
            stavka_method();
            workers_method();
            mat_norm_method();
            try
            {
                p_time();
            }
            catch
            {
                time_f.Text = "00";
                time_f1.Text = "00";
                time_f2.Text = "00";
            }
            try
            {
                p_rab();
            }
            catch
            {
                label10.DataBindings.Clear();
                label11.DataBindings.Clear();
                label12.DataBindings.Clear();
                label13.DataBindings.Clear();
            }
        }

        private void p_rab()//вывод рабочих после паузы
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "SELECT rab_name FROM [zp]  WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + id_op.Text + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connectionString))
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(connectionString);
                dataAdapter.Fill(ds);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    label10.Visible = false;
                    label10.DataBindings.Clear();
                    label11.Visible = false;
                    label11.DataBindings.Clear();
                    label12.Visible = false;
                    label12.DataBindings.Clear();
                    label13.Visible = false;
                    label13.DataBindings.Clear();
                }
                else if (ds.Tables[0].Rows.Count == 1)
                {
                    label10.Text = ds.Tables[0].Rows[0][0].ToString();
                    label10.Visible = true;
                }
                else if (ds.Tables[0].Rows.Count == 2)
                {
                    label10.Text = ds.Tables[0].Rows[0][0].ToString();
                    label10.Visible = true;
                    label11.Text = ds.Tables[0].Rows[1][0].ToString();
                    label11.Visible = true;
                }
                else if (ds.Tables[0].Rows.Count == 3)
                {
                    label10.Text = ds.Tables[0].Rows[0][0].ToString();
                    label10.Visible = true;
                    label11.Text = ds.Tables[0].Rows[1][0].ToString();
                    label11.Visible = true;
                    label12.Text = ds.Tables[0].Rows[2][0].ToString();
                    label12.Visible = true;
                }
                else if (ds.Tables[0].Rows.Count == 4)
                {
                    label10.Text = ds.Tables[0].Rows[0][0].ToString();
                    label10.Visible = true;
                    label11.Text = ds.Tables[0].Rows[1][0].ToString();
                    label11.Visible = true;
                    label12.Text = ds.Tables[0].Rows[2][0].ToString();
                    label12.Visible = true;
                    label13.Text = ds.Tables[0].Rows[3][0].ToString();
                    label13.Visible = true;
                }
                conn.Close();
            }
        }

        private void p_time()
        {
            p_hours();
            p_minutes();
            p_seconds();
        }

        private void p_hours()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "SELECT p_hours FROM [p_time]  WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + id_op.Text + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connectionString))
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                time_f.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["p_time"], "p_hours"));
                cmd.Parameters.AddWithValue("@number", time_f.Text);
                string h = Convert.ToString(time_f.Text);
                time_f.Text = (cmd.ExecuteScalar().ToString());
                conn.Close();
            }
        }

        private void p_minutes()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "SELECT [p_minutes] FROM [p_time]  WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + id_op.Text + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connectionString))
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                time_f1.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["p_time"], "p_minutes"));
                cmd.Parameters.AddWithValue("@number", time_f1.Text);
                string m = Convert.ToString(time_f1.Text);
                time_f1.Text = (cmd.ExecuteScalar().ToString());
                conn.Close();
            }
        }

        private void p_seconds()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "SELECT [p_seconds] FROM [p_time]  WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + id_op.Text + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connectionString))
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                time_f2.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["p_time"], "p_seconds"));
                cmd.Parameters.AddWithValue("@number", time_f2.Text);
                string s = Convert.ToString(time_f2.Text);
                time_f2.Text = (cmd.ExecuteScalar().ToString());
                conn.Close();
            }
        }


        private void workers_method()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
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


        private void stavka_method()
        {
            string connectionString2 = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString2 = "SELECT stavka FROM [stavka] WHERE [id_post] = '" + label15.Text + "' ";
            using (SqlDataAdapter dataAdapter2 = new SqlDataAdapter(queryString2, connectionString2))
            {
                DataSet ds2 = new DataSet();
                SqlConnection conn2 = new SqlConnection(connectionString2);
                conn2.Open();
                SqlCommand cmd = new SqlCommand(queryString2, conn2);
                stavka.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["stavka"], "stavka"));
                cmd.Parameters.AddWithValue("@number", stavka.Text);
                stavka.Text = (cmd.ExecuteScalar().ToString());
                conn2.Close();
            }
        }

        private void id_op_method()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "SELECT [id_op],[op_name],[kol_rab],[time_norm] FROM [progress] WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [complete] =  0";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connectionString))
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                id_op.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "id_op"));
                cmd.Parameters.AddWithValue("@number", id_op.Text);
                id_op.Text = (cmd.ExecuteScalar().ToString());
                conn.Close();
            }
        }

        private void kol_rab_method()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "SELECT [kol_rab] FROM [progress] WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [complete] =  0";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connectionString))
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                kol_rab.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "kol_rab"));
                cmd.Parameters.AddWithValue("@number", kol_rab.Text);
                kol_rab.Text = (cmd.ExecuteScalar().ToString());
                conn.Close();
            }
        }

        private void time_norm_method()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "SELECT [time_norm] FROM [progress] WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [complete] =  0";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connectionString))
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                time_n.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "time_norm"));
                cmd.Parameters.AddWithValue("@number", time_n.Text);
                time_n.Text = (cmd.ExecuteScalar().ToString());
                conn.Close();
            }
        }

        private void mat_norm_method()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            //var select = "SELECT [id_v],[id_post],[id_op],[id_mat],[kol_mat],[izm] FROM [mat_norm] WHERE [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + id_op.Text + "'";
            var select = "SELECT [id_mat],[kol_mat],[izm] FROM [mat_norm] WHERE [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + id_op.Text + "'";
            var c = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter1);
            var dss = new DataSet();
            dataAdapter1.Fill(dss);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dss.Tables[0];

        }

        private void op_name_method()
        {
            dataGridView1.Visible = true;
            Convert.ToInt32(label15.Text);
            Convert.ToInt32(label16.Text);
            Convert.ToInt32(label6.Text);
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "SELECT [op_name] FROM [progress] WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [complete] = 0";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connectionString))
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                conn.Open();
                op_name_label.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "op_name"));
                cmd.Parameters.AddWithValue("@number", op_name_label.Text);
                op_name_label.Text = (cmd.ExecuteScalar().ToString());
                conn.Close();
            }
        }

        private void complete_method()
        {
            string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            SqlConnection connect = new SqlConnection(connection);
            string sql = "UPDATE progress SET complete = 1 WHERE [zav_n] = '" + label6.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + id_op.Text + "' ";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            //cmd_SQL.Parameters.AddWithValue("@complete", st);
           
            try
            {
                if (label10.Visible == true && label11.Visible == false && label12.Visible == false && label13.Visible == false)
                {
                    connect.Open();
                    progressTableAdapter.Update(dubakby_VIPODataSet.progress);
                    cmd_SQL.ExecuteNonQuery();
                    MessageBox.Show("Операция " + op_name_label.Text + " выполнена рабочим " + label10.Text + " за " + label18.Text + " минут.");
                }
                else if (label10.Visible == true && label11.Visible == true && label12.Visible == false && label13.Visible == false)
                {
                    connect.Open();
                    progressTableAdapter.Update(dubakby_VIPODataSet.progress);
                    cmd_SQL.ExecuteNonQuery();
                    MessageBox.Show("Операция " + op_name_label.Text + " выполнена рабочими " + label10.Text + " и " + label11.Text + " за " + label18.Text + " минут.");
                }
                else if (label10.Visible == true && label11.Visible == true && label12.Visible == true && label13.Visible == false)
                {
                    connect.Open();
                    progressTableAdapter.Update(dubakby_VIPODataSet.progress);
                    MessageBox.Show("Операция " + op_name_label.Text + " выполнена рабочими: " + label10.Text + ", " + label11.Text + " и " + label12.Text + " за " + label18.Text + " минут.");
                }
                else
                {
                    connect.Open();
                    progressTableAdapter.Update(dubakby_VIPODataSet.progress);
                    cmd_SQL.ExecuteNonQuery();
                    MessageBox.Show("Операция " + op_name_label.Text + " выполнена рабочими: " + label10.Text + ", " + label11.Text + ",\n " + label12.Text + " и " + label13.Text + " за " + label18.Text + " минут.");
                }  
            }
            catch (SqlException ex)
            {

                throw new ApplicationException("error insert zp", ex);

            }
            finally
            {
                connect.Close();
            }
        }

        private void img_method()
        {
            string connectionString1 = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            SqlConnection Con = new SqlConnection(connectionString1);

            SqlCommand command = new SqlCommand("SELECT [img] FROM [op_norm] WHERE [id_op] = '" + id_op.Text + "'", Con); //Команда выбора данных
            Con.Open(); //Открываем соединение
            SqlDataReader read = command.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                label19.Text = (read.GetValue(0).ToString()); //Добавляем данные в лист итем
            }
            Con.Close();
            string img = label19.Text;
            pictureBox1.Image = Image.FromFile(img);
            pictureBox1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            p_rab();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void notifyIcon1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //this.WindowState = FormWindowState.Normal;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Рабочий не выбран!");
            }
            else
            {
                label9.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label21.DataBindings.Clear();
            next_id_op();
        }

        private void next_id_op()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "SELECT MIN(id_op) FROM [progress] WHERE [id_op]>'" + id_op.Text + "' and [zav_n] = '" + label6.Text + "' and [id_v] = '" + label16.Text + "' and [id_post] = '" + label15.Text + "' and [complete] = 0";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connectionString))
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                label21.DataBindings.Add(new Binding("Text", dubakby_VIPODataSet.Tables["progress"], "id_op"));
                cmd.Parameters.AddWithValue("@number", label21.Text);
                label21.Text = (cmd.ExecuteScalar().ToString());
                conn.Close();
            }
        }

        private void label21_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label21.Text))
            {
                button7_Click(sender, e);
            }
            else
            {
                id_op.DataBindings.Clear();
                id_op.Text = label21.Text;
                op_name_label.DataBindings.Clear();
                time_n.DataBindings.Clear();
                kol_rab.DataBindings.Clear();
                listBox2.Items.Clear();
                time_f.DataBindings.Clear();
                time_f1.DataBindings.Clear();
                time_f2.DataBindings.Clear();
                label10.DataBindings.Clear();
                label11.DataBindings.Clear();
                label12.DataBindings.Clear();
                label13.DataBindings.Clear();
                next_op_name();
                next_time_norm();
                next_kol_rab();
                next_mat_norm();
                next_img();
                try
                    {
                        p_time();
                    }
                    catch
                    {
                        time_f.Text = "00";
                        time_f1.Text = "00";
                        time_f2.Text = "00";
                    }
                try
                    {
                        p_rab();
                    }
                    catch
                    {
                        label10.DataBindings.Clear();
                        label11.DataBindings.Clear();
                        label12.DataBindings.Clear();
                        label13.DataBindings.Clear();
                    }
            }
        }

        private void next_op_name()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            SqlConnection Con = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT[op_name] FROM[progress] WHERE[zav_n] = '" + label6.Text + "'  AND[id_v] = '" + label16.Text + "' AND[id_post] = '" + label15.Text + "' AND[id_op] = '" + label21.Text + "' AND[complete] = 0", Con); //Команда выбора данных
            Con.Open(); //Открываем соединение
            SqlDataReader read = command.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                op_name_label.Text = (read.GetValue(0).ToString()); //Добавляем данные в лист итем
            }
            Con.Close();
        }

        private void next_img()
        {
            string connectionString1 = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            SqlConnection Con = new SqlConnection(connectionString1);
            SqlCommand command = new SqlCommand("SELECT [img] FROM [op_norm] WHERE [id_op] = '" + label21.Text + "'", Con); //Команда выбора данных
            Con.Open(); //Открываем соединение
            SqlDataReader read = command.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                label19.Text = (read.GetValue(0).ToString()); //Добавляем данные в лист итем
            }
            Con.Close();
            string img = label19.Text;
            pictureBox1.Image = Image.FromFile(img);
        }

        private void next_mat_norm()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            var select = "SELECT [id_mat],[kol_mat],[izm] FROM [mat_norm] WHERE [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + label21.Text + "'";
            var c = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter1);
            var dss = new DataSet();
            dataAdapter1.Fill(dss);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dss.Tables[0];
        }

        private void next_time_norm()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            SqlConnection Con = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT [time_norm] FROM [progress] WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + label21.Text + "' AND [complete] =  0", Con); //Команда выбора данных
            Con.Open(); //Открываем соединение
            SqlDataReader read = command.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                time_n.Text = (read.GetValue(0).ToString()); //Добавляем данные в лист итем
            }
            Con.Close();
        }

        private void next_kol_rab()
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            SqlConnection Con = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT [kol_rab] FROM [progress] WHERE [zav_n] = '" + label6.Text + "'  AND [id_v] = '" + label16.Text + "' AND [id_post] = '" + label15.Text + "' AND [id_op] = '" + label21.Text + "' AND [complete] =  0", Con); //Команда выбора данных
            Con.Open(); //Открываем соединение
            SqlDataReader read = command.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                kol_rab.Text = (read.GetValue(0).ToString()); //Добавляем данные в лист итем
            }
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pauza pauza = new pauza();
            string zav_n1 = Convert.ToString(label6.Text);
            pauza.label2.Text = zav_n1;
            string id_v1 = Convert.ToString(label16.Text);
            pauza.label3.Text = id_v1;
            string id_post1 = Convert.ToString(label15.Text);
            pauza.label4.Text = id_post1;
            string id_op1 = Convert.ToString(id_op.Text);
            pauza.label5.Text = id_op1;
            string op_name1 = Convert.ToString(op_name_label.Text);
            pauza.label8.Text = op_name1;
            string v_name1 = Convert.ToString(label4.Text);
            pauza.label9.Text = v_name1;
            string h1 = Convert.ToString(time_f.Text);
            pauza.label6.Text = h1;
            string m1 = Convert.ToString(time_f1.Text);
            pauza.label10.Text = m1;
            string s1 = Convert.ToString(time_f2.Text);
            pauza.label11.Text = s1;
            button3.Enabled = false;
            button2.Enabled = false;
            pauza.Show();
        }
    }
}
