﻿using System;
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
            dgw_gl_in.Refresh();
        }

        private void gl_in_Load(object sender, EventArgs e)
        {
            vishkiTableAdapter.Fill(dubakby_VIPODataSet.vishki);
            plan_agpTableAdapter.Fill(dubakby_VIPODataSet.plan_agp);
            dgw_gl_in.Refresh();
            dgw_gl_in.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
        }

        public void addbutton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || String.IsNullOrEmpty(textBox1.Text))
            {
                DialogResult result = MessageBox.Show("Вышка не добавлена!\nПроверьте, все ли значения введены.", "Ошибка добавления", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if (result == DialogResult.Cancel)
                {}
            }
            else
            {
                string myConnectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                string mySelectQuery = "SELECT [zav_n] FROM [plan_agp] WHERE [zav_n] = '" + textBox1.Text + "'";

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, myConnectionString))
                {
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    if (table.Rows.Count == 0)
                            {
                        DataRow nRow = dubakby_VIPODataSet.Tables[6].NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = label5.Text;
                        nRow[2] = comboBox2.Text;
                        nRow[3] = dateTimePicker1.Text;
                        dubakby_VIPODataSet.Tables[6].Rows.Add(nRow);
                        plan_agpTableAdapter.Update(dubakby_VIPODataSet.plan_agp);
                        dubakby_VIPODataSet.Tables[6].AcceptChanges();
                        dgw_gl_in.Refresh();
                        textBox1.Clear();
                        plan_agpTableAdapter.Fill(dubakby_VIPODataSet.plan_agp);
                            }
                            else
                            {
                        MessageBox.Show("Вышка не добавлена!\nПроверьте правильность ввода заводского номера!", "Ошибка добавления", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                        }
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
                if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    int delet = dgw_gl_in.SelectedCells[0].RowIndex;
                    dgw_gl_in.Rows.RemoveAt(delet);
                    plan_agpTableAdapter.Update(dubakby_VIPODataSet);
                }
            }
            catch
            {
                MessageBox.Show("Нельзя удалить запись, т.к. она не выбрана.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "INSERT INTO plan_all (zav_n, id_v, volt, data_pl, data_v) SELECT zav_n, id_v, volt, data_pl, [data_v] = 0 FROM plan_agp;INSERT INTO progress(zav_n, id_v, id_post, id_op, num_op, op_name, kol_rab, time_norm, proc_op, f_time, otkl) SELECT plan_agp.zav_n, op_norm.id_v, op_norm.id_post, op_norm.id_op, op_norm.num_op, op_norm.op_name, op_norm.kol_rab, op_norm.time_norm, op_norm.proc_op, [f_time] = 0, [otkl] = 0 FROM op_norm INNER JOIN plan_agp ON plan_agp.id_v = op_norm.id_v;TRUNCATE TABLE plan_agp END  FROM plan_agp";//"SELECT CASE WHEN [plan_agp].[zav_n] <> [plan_all].[zav_n] THEN  END FROM mytable"
            //SELECT zav_n, id_v, volt, data_pl CASE WHEN[plan_agp].[zav_n] <> [plan_all].[zav_n] THEN INSERT INTO numbers(zav_n, id_v) SELECT zav_n, id_v FROM plan_agp;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString,connectionString);
            DataTable table1 = new DataTable();
            sqlDataAdapter.Fill(table1);*/
            if (dgw_gl_in.Rows.Count == 0)
            {
                MessageBox.Show("Ошибка добавления\nПлан ПУСТ!", "Добавление плана", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else /*if(table1.Rows.Count != 0)*/
            {
                string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
                string queryString = "INSERT INTO plan_all (zav_n, id_v, volt, data_pl) SELECT zav_n, id_v, volt, data_pl FROM plan_agp;INSERT INTO progress(zav_n, id_v, id_post, num_op, op_name, kol_rab, time_norm, proc_op, f_time, otkl) SELECT plan_agp.zav_n, op_norm.id_v, op_norm.id_post, op_norm.num_op, op_norm.op_name, op_norm.kol_rab, op_norm.time_norm, op_norm.proc_op, [f_time] = 0, [otkl] = 0 FROM op_norm INNER JOIN plan_agp ON plan_agp.id_v = op_norm.id_v;INSERT INTO numbers (zav_n,id_v) SELECT zav_n, id_v FROM plan_agp;TRUNCATE TABLE plan_agp";//"SELECT CASE WHEN [plan_agp].[zav_n] <> [plan_all].[zav_n] THEN  END FROM mytable"
                using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            using (SqlCommand command = connection.CreateCommand())
                            {
                                command.CommandText = queryString;
                                connection.Open();
                                command.ExecuteNonQuery();
                                DialogResult dialogResult = MessageBox.Show("План успешно добавлен!", "Добавление плана", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                plan_agpTableAdapter.Fill(dubakby_VIPODataSet.plan_agp);
                                dgw_gl_in.Refresh();
                            }
                        }
                    
                    /*else
                    {
                        MessageBox.Show("План не добавлен!\nТакой заводской номер уже был использован ранее!", "Ошибка добавления", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }*/
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
