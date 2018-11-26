using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoNguyenLon
{
    public partial class FormSoLuong : Form
    {
        public FormSoLuong()
        {
            InitializeComponent();
        }

        private void btnOkKhoiTao_Click_1(object sender, EventArgs e)
        {
            if (txtSoLuongKhoiTao.Text != string.Empty)
            {
                Form1.SoLuong = txtSoLuongKhoiTao.Text;
                this.Close();
            }
        }

        private void btnCancelKhoiTao_Click_1(object sender, EventArgs e)
        {            
            Form1.SoLuong = "";
            this.Close();
        }

        private void txtSoLuongKhoiTao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (txtSoLuongKhoiTao.Text != string.Empty)
                {
                    Form1.SoLuong = txtSoLuongKhoiTao.Text;
                    this.Close();
                }
            }
        }

        private void txtSoLuongKhoiTao_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuongKhoiTao.Text))
            {
                e.Cancel = true;
                txtSoLuongKhoiTao.Focus();
                errorProvider1.SetError(txtSoLuongKhoiTao, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSoLuongKhoiTao, null);
            }
        }
    }
}
