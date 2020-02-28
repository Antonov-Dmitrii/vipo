using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vipo
{
    public partial class gl_in : Form
    {
         string conn_string = @"Data Source=93.125.99.108;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
        
        public gl_in()
        {
            InitializeComponent();

           
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            DataRow nRow = dubakby_VIPODataSet.Tables[5].NewRow();
            nRow[0] = textBox1.Text;
            nRow[1] = comboBox1.Text;
            nRow[2] = comboBox2.Text;
            nRow[3] = dateTimePicker1.Text;
            dubakby_VIPODataSet.Tables[5].Rows.Add(nRow);
            plan_agpTableAdapter.Update(dubakby_VIPODataSet.plan_agp);
            dubakby_VIPODataSet.Tables[5].AcceptChanges();
            dataGridView1.Refresh();
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
            this.plan_agpTableAdapter.Fill(this.dubakby_VIPODataSet.plan_agp);
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
          /*  using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("sp_CreateUser", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@age", SqlDbType.Int, 0, "Age"));

                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                adapter.Update(ds);
            }*/
        }

        private void gl_in_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.vishki". При необходимости она может быть перемещена или удалена.
            this.vishkiTableAdapter.Fill(this.dubakby_VIPODataSet.vishki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.plan_agp". При необходимости она может быть перемещена или удалена.
            //this.plan_agpTableAdapter.Fill(this.dubakby_VIPODataSet.plan_agp);
            /*this.view_StudentTableAdapter.Fill(this.educationDataSet.View_Student);*/
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
           /* string cmd_text = "DELETE FROM Student";
            int index;
            string num_book;

            index = dataGridView1.CurrentRow.Index;
            num_book = Convert.ToString(dataGridView1[0, index].Value);
            cmd_text = "DELETE FROM Student WHERE [Student].[Num_book] = '" + num_book + "'";

            SqlConnection sql_conn = new SqlConnection(conn_string);
            SqlCommand sql_comm = new SqlCommand(cmd_text, sql_conn);

            sql_conn.Open();
            sql_comm.ExecuteNonQuery();
            sql_conn.Close();

            this.view_StudentTableAdapter.Fill(this.educationDataSet.View_Student);*/
        }

        private void progress_button_Click(object sender, EventArgs e)
        {
            progress prog = new progress();
            prog.Show();
        }
    }
}
