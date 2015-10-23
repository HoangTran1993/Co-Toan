using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CoToan.DATA;


namespace CoToan
{
    public partial class FormLuaChonCheDoChoi : Form
    {
        //
        ThongTinVanCo thongtin = new ThongTinVanCo();
        int mode = 1;

        //
        public static string nguoichoi1;
        public static string nguoichoi2;

        //
        public FormLuaChonCheDoChoi()
        {
            InitializeComponent();
        }


        public Boolean CheckThongTin() 
        {
            if ((!String.IsNullOrWhiteSpace(txtNguoiChoi1.Text)) && (!String.IsNullOrWhiteSpace(txtNguoiChoi2.Text)) &&(txtNguoiChoi1.Text!=txtNguoiChoi2.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Vui lòng điền tên người chơi!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            
        }

        //
        //
        //
        private void btStart_Click(object sender, EventArgs e)
        {
            //if (CheckThongTin())
            //{
                nguoichoi1 = txtNguoiChoi1.Text;
                nguoichoi2 = txtNguoiChoi2.Text;
                this.Hide();
                FormBanCo fbanco = new FormBanCo();
                fbanco.ShowDialog();
                this.Close();
            //}
        }
    }
}
