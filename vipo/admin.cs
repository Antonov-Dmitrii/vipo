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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            int rCnt;
            int cCnt;

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Excel (*.XLSX)|*.XLSX";
            opf.ShowDialog();
            System.Data.DataTable tb = new System.Data.DataTable();
            string filename = opf.FileName;

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            Microsoft.Office.Interop.Excel.Range ExcelRange;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false,
                false, 0, true, 1, 0);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            ExcelRange = ExcelWorkSheet.UsedRange;
            for (rCnt = 1; rCnt <= ExcelRange.Rows.Count; rCnt++)
            {
                dataGridView1.Rows.Add(1);
                for (cCnt = 1; cCnt <= 6; cCnt++)
                {
                    str = (string)(ExcelRange.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Text;
                    dataGridView1.Rows[rCnt - 1].Cells[cCnt - 1].Value = str;
                }
            }
            ExcelWorkBook.Close(true, null, null);
            ExcelApp.Quit();

            releaseObject(ExcelWorkSheet);
            releaseObject(ExcelWorkBook);
            releaseObject(ExcelApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SqlConnection con = new SqlConnection("Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312");
                SqlCommand cmd = new SqlCommand("INSERT INTO sklad ([id_v], [id_post], [num_op], [mat_name], [id_v])VALUES(@id_mat, @mat_name, @id_post, @kol, @id_v)", con);
                cmd.Parameters.AddWithValue("@id_mat", dataGridView1.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@mat_name", dataGridView1.Rows[i].Cells[1].Value);
                cmd.Parameters.AddWithValue("@id_post", dataGridView1.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@kol", dataGridView1.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@id_v", dataGridView1.Rows[i].Cells[4].Value);

                try
                {
                    con.Open();
                    //matnormTableAdapter.Update(dubakby_VIPODataSet.matnorm);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    throw new ApplicationException("error insert mat_norm", ex);

                }
                finally
                {

                    con.Close();
                }
            }
        }
    }
}
