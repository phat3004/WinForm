using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BAL;
using BEL;

namespace DOANPQSHOP
{
    public partial class Form1 : Form
    {
        public static string SQL;
        public Form1()
        {
            InitializeComponent();
        }

        private void btQL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSQL.Text))
            {
                MessageBox.Show("Chưa nhập Server?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSQL.Focus();
            }
            else
            {
                General.SQL = tbSQL.Text;
                Login_Admin fr2 = new Login_Admin();
                fr2.ShowDialog();
                bool flag = fr2.flag;
                fr2.Close();
            }
        }

        private void btNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSQL.Text))
            {
                MessageBox.Show("Chưa nhập Server?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSQL.Focus();
            }
            else
            {
                General.SQL = tbSQL.Text;
                Login_NV fr2 = new Login_NV();
                fr2.ShowDialog();
                bool flag = fr2.flag;
                fr2.Close();
            }
        }

        private void btKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSQL.Text))
            {
                MessageBox.Show("Chưa nhập Server?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSQL.Focus();
            }
            else
            {
                try
                {
                    General.SQL = tbSQL.Text;
                    KhachHang fr4 = new KhachHang();
                    fr4.ShowDialog();
                    bool flag = fr4.flag;
                    fr4.Close();
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đúng tên CSDL ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btEsc_Click(object sender, EventArgs e)
        {
            DialogResult Thoat = MessageBox.Show("Bạn thực sự muốn thoát !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoat == DialogResult.Yes)
            {
                General.SQL = null;
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Helpcs help = new Helpcs();
            help.ShowDialog();
            help.Close();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Helpcs help = new Helpcs();
                help.ShowDialog();
                help.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
