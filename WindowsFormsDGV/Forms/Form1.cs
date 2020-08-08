using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsDGV
{
    public partial class ShohinForm : Form
    {
        public ShohinForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnClearGridView_Click(object sender, EventArgs e)
        {
            this.dgvShohin.DataSource = null;
            this.dgvShohin.Rows.Clear();
            this.tbError.Clear();
        }
        private void btnExtractSQL_Click(object sender, EventArgs e)
        {
            this.btnClearGridView_Click(sender,e);
            var dt = new DataTable();
            using (var con = DBConnection.GetInstance())
            {
                using (var cmd = con.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = ShohinQuery.SelectAll;
                        using (var sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                        }
                        var shohinList = new ShohinList(dt);
                        ShohinListHelper.ToDataGridView(this.dgvShohin, shohinList);
                    }
                    catch (Exception ex)
                    {
                        this.tbError.Text += ex.ToString() + "\n";
                        this.tbError.Text += ex.Message + "\n";
                        this.tbError.Text += ex.StackTrace + "\n";
                    }
                }
            }
        }
       
    }
}
