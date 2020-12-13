using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANPQSHOP
{
    public partial class QMKQL : Form
    {
        private int n;
        public bool flag;
        public QMKQL()
        {
            InitializeComponent();
        }
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            try
            {
                flag = true;
                n = int.Parse(tbCM.Text);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("CMND phải nhập số nha!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCM.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Lấy CMND ra mà coi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            tbCM.Focus();
        }
    }
}
