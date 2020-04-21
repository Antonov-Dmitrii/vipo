using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vipo
{
    public partial class pauza : Form
    {

        public pauza(/*string zav_n1, string id_v1, string id_post1, string id_op1, string p_start1*/)
        {
            /*label2.Text = Convert.ToString(zav_n1);
            label3.Text = Convert.ToString(id_v1);
            label4.Text = Convert.ToString(id_post1);
            label5.Text = Convert.ToString(id_op1);
            label6.Text = Convert.ToString(p_start1);*/

            InitializeComponent();
        }

        private void pauza_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.p_reasons". При необходимости она может быть перемещена или удалена.
            this.p_reasonsTableAdapter.Fill(this.dubakby_VIPODataSet.p_reasons);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            SqlConnection connect = new SqlConnection(connection);
            string sql = "UPDATE p_time SET id_p = @id_p, p_hours = '" + label6.Text + "' , p_minutes = '" + label10.Text + "' , p_seconds = '" + label11.Text + "' WHERE [zav_n] = '" + label2.Text + "'  AND [id_v] = '" + label3.Text + "' AND [id_post] = '" + label4.Text + "' AND [id_op] = '" + label5.Text + "'";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            cmd_SQL.Parameters.AddWithValue("@id_p", label1.Text);
            if(MessageBox.Show("Операция " + label8.Text + "\nпо вышке " + label9.Text + " с заводским номером " + label2.Text + "\nприостановлена по причине " + label7.Text + ".", "Пауза поставлена", MessageBoxButtons.OK, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
            }

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
    }
}
