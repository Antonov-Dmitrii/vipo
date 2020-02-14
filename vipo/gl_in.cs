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
    public partial class gl_in : Form
    {
        /*string conn_string = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True;Pooling=False";*/


        public gl_in()
        {
            InitializeComponent();

           
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
          /*  string cmd_text;
            Form2 f2 = new Form2();
            int index;
            string num_book;

            index = dataGridView1.CurrentRow.Index;
            num_book = Convert.ToString(dataGridView1[0, index].Value);

            f2.textBox1.Text = num_book;
            f2.textBox2.Text = Convert.ToString(dataGridView1[1, index].Value);
            f2.textBox3.Text = Convert.ToString(dataGridView1[2, index].Value);
            f2.textBox4.Text = Convert.ToString(dataGridView1[3, index].Value);

            if (f2.ShowDialog() == DialogResult.OK)
            {
                cmd_text = "UPDATE Student SET Num_book = '" + f2.textBox1.Text + "', " +
                "[Name] = '" + f2.textBox2.Text + "', " +
                "[Group] = '" + f2.textBox3.Text + "', " +
                "Year = " + f2.textBox4.Text +
                "WHERE Num_book = '" + num_book + "'";

                SqlConnection sql_conn = new SqlConnection(conn_string);
                SqlCommand sql_comm = new SqlCommand(cmd_text, sql_conn);

                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();

                this.view_StudentTableAdapter.Fill(this.educationDataSet.View_Student);
            }*/
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
    }
}
