using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHSC3.DTO;
using System.Xml;
using QLHSC3.DAO;

namespace QLHSC3.GUI
{
    public partial class frmDangNhap : DevComponents.DotNetBar.Office2007Form
    {
        XmlNodeList Danh_Sach;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.Multiline = true;
            txtMatKhau.Size = new System.Drawing.Size(178, 25);

            XmlElement Lich_Su = XL_XML.Doc_goc();
            Danh_Sach = Lich_Su.SelectNodes("TAI_KHOAN");
            XL_XML.Xuat(Danh_Sach,txtTenDN,"Ten_Dang_Nhap");
            XL_ChonTaiKhoan(Danh_Sach);
        }

        public void XL_ChonTaiKhoan(XmlNodeList Danh_sach)
        {
            XmlElement TK = XL_XML.Chon(txtTenDN);
            if (TK != null)
            {
                txtMatKhau.Text = TK.Attributes["Mat_Khau"].Value;
            }
        }

        private void txtTenDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            XL_ChonTaiKhoan(Danh_Sach);
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            bool flag = false;
            flag = Convert.ToBoolean(cbGhiNho.CheckState);
            TaiKhoanDangNhap taiKhoanHienTai = new TaiKhoanDangNhap(txtTenDN.Text, txtMatKhau.Text);
            //Load tai khoan dang nhap len
            TaiKhoanDAO Adapter = new TaiKhoanDAO();
            TaiKhoanDangNhap[] listTaiKhoan = Adapter.getAllUser();
            int KQ=0;
            if (listTaiKhoan != null && listTaiKhoan.Length > 0)
            {
                foreach (TaiKhoanDangNhap TaiKhoan in listTaiKhoan)
                {
                    KQ = TaiKhoan.kiemTraTaiKhoanDangNhap(taiKhoanHienTai);
                    if (KQ == 0)
                    {
                        
                    }
                    else
                    {
                        BienToanCuc.CurrentUser = new TaiKhoanDangNhap();
                        BienToanCuc.CurrentUser = TaiKhoan;
                        if (flag == true)
                        {
                            XL_XML.ThemTKVaoLSDN(txtTenDN.Text, txtMatKhau.Text);
                        }
                        BienToanCuc.loai_nguoi_dung = KQ;

                        this.Visible = false;
                        frmMain frm = new frmMain();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
                MessageBox.Show("Mật khẩu sai, vui lòng kiểm tra lại", "Chú ý");
                
            }
            else
            {
                MessageBox.Show("Hệ thống quá tải, vui lòng đăng nhập sau 5 phút nữa!", "Chú ý");
            }

            
        }

    }
}
