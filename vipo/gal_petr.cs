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
using PagedList;

namespace vipo
{
    public partial class gal_petr : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
        string sql = "SELECT * FROM zp";

        public gal_petr()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void gal_petr_Load(object sender, EventArgs e)
        {
            
        }
        Bitmap bmp;
        private void button3_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width , dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filtr();
        }

        private void filtr()
        {
            if (radioButton1.Checked == true)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
       String.Format("rab_name like '{0}%'", textBox1.Text);
            }
            if (radioButton2.Checked == true)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
       String.Format("Convert ([zav_n], System.String) like '{0}%'", textBox1.Text);
            }
            if (radioButton3.Checked == true)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
       String.Format("Convert ([id_v], System.String) like '{0}%'", textBox1.Text);
            }
            if (radioButton4.Checked == true)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
       String.Format("Convert ([id_post], System.String) like '{0}%'", textBox1.Text);
            }
            else if((radioButton1.Checked == true) && (radioButton2.Checked == true) && (radioButton3.Checked == true) && (radioButton4.Checked == true))
                {
                    MessageBox.Show("Выберите столбец для фильтрации");
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Cells[1, 1] = "Фамилия работника";
            ExcelWorkSheet.Cells[2, 1] = "Заводской номер";
            ExcelWorkSheet.Cells[3, 1] = "Номер подъёмника";
            ExcelWorkSheet.Cells[4, 1] = "Номер поста";
            ExcelWorkSheet.Cells[5, 1] = "Номер операции";
            ExcelWorkSheet.Cells[6, 1] = "Норма времени";
            ExcelWorkSheet.Cells[7, 1] = "Завершение операции";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
