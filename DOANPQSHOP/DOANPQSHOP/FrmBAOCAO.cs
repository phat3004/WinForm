using Microsoft.Reporting.WinForms;
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

namespace DOANPQSHOP
{
    public partial class FrmBAOCAO : Form
    {
        public FrmBAOCAO()
        {
            InitializeComponent();
        }
        public string _NhanVien;
        public double _TienKhachDua;
        public double _KM;
        public static int Dem = 0;
        private void FrmBAOCAO_Load(object sender, EventArgs e)
        {

            this.rpvIn_HD.RefreshReport();
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =" + Form1.SQL + ";Initial Catalog=QLSHOPQA;Integrated Security = True";
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string query ="select * from tbHoaDon where DaTru = 'N' and Trung = 0";
            SqlCommand cmd = new SqlCommand(query,con);
            //proc
            DataSet ds = new DataSet();

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            //cdxl
            rpvIn_HD.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //lik
            rpvIn_HD.LocalReport.ReportPath = "ReportIn_HD.rdlc";
            ReportParameterCollection rppm = new ReportParameterCollection();
            rppm.Add(new ReportParameter("prtNhanVien", this._NhanVien));
            rppm.Add(new ReportParameter("prtTienKhachDua", this._TienKhachDua.ToString()));
            rppm.Add(new ReportParameter("prtKM", this._KM.ToString()));
            rpvIn_HD.LocalReport.SetParameters(rppm);
            
            MessageBox.Show(ds.Tables[0].Rows.Count.ToString(), "Số dòng được load!");
            if (ds.Tables[0].Rows.Count > 0)
            {
                
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "rpvHoaDon";
                rds.Value = ds.Tables[0];
                //xóa dl báo cáo cũ trong trường hợp người dùng thực hiện truy vấn khác
                rpvIn_HD.LocalReport.DataSources.Clear();
                //add dl vào báo cáo
                rpvIn_HD.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvIn_HD.RefreshReport();
            }
            Dem++;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bill bill = new Bill();
            this.Visible = false;
            bill.ShowDialog();
            bill.Close();
        }

        private void rpvIn_HD_Load(object sender, EventArgs e)
        {

        }

    }
}
