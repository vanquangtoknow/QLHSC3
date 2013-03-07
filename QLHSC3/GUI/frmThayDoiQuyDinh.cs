using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHSC3.DAO;
using QLHSC3.DTO;

namespace QLHSC3.GUI
{
    public partial class frmThayDoiQuyDinh : DevComponents.DotNetBar.Office2007Form
    {
        bool flag = false;
        QuyDinh[] DanhSachQD;
        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
        }


        private void btnLuuThem_Click_1(object sender, EventArgs e)
        {
            string tenQD = txtTenQD.Text;
            string noiDungQD = txtNoiDungQD.Text;
            if (tenQD != "" && noiDungQD != "")
            {
                QuyDinhDAO adapterQD = new QuyDinhDAO();
                if (adapterQD.ThemQuyDinh(tenQD, noiDungQD))
                {
                    MessageBox.Show("Đã thêm!");
                    txtTenQD.Clear();
                    txtNoiDungQD.Clear();
                }
                else
                {
                    MessageBox.Show("Hệ thống bị lỗi!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
            }
        }

        private void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            capNhat();
        }

        private void capNhat()
        {
            flag = false;
            if (flag == false)
            {
                QuyDinhDAO adapterQD = new QuyDinhDAO();
                QuyDinh[] Danh_Sach_QD = adapterQD.getAllQuyDinh();
                if (Danh_Sach_QD.Length > 0)
                {
                    combQuyDinh.DataSource = Danh_Sach_QD;
                    combQuyDinh.DisplayMember = "tenQuyDinh";
                    combQuyDinh.Tag = Danh_Sach_QD;

                    combQuyDinhXoa.DataSource = Danh_Sach_QD;
                    combQuyDinhXoa.DisplayMember = "tenQuyDinh";
                    combQuyDinhXoa.Tag = Danh_Sach_QD;

                    flag = true;
                    XL_Chon();
                    XL_Chon2();
                }
                else
                {
                    MessageBox.Show("Không còn quy định nào trong hệ thống!");
                    combQuyDinhXoa.DataSource = null;
                    combQuyDinh.DataSource = null;
                    lbQDCu2.Text = "";
                    lbQuyDinhCu.Text = "";
                }
            }
            
        }

        private void XL_Chon()
        {
            if (flag == true)
            {
                DanhSachQD= (QuyDinh[])combQuyDinh.Tag;
                lbQuyDinhCu.Text = DanhSachQD[combQuyDinh.SelectedIndex].NoiDungQuyDinh;
            }
        }

        private void XL_Chon2()
        {
            if (flag == true)
            {
                DanhSachQD = (QuyDinh[])combQuyDinh.Tag;
                lbQDCu2.Text = DanhSachQD[combQuyDinhXoa.SelectedIndex].NoiDungQuyDinh;
            }
        }

        private void combQuyDinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            XL_Chon();
        }

        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            
            if (txtNoiDungQDMoi.Text!="" && combQuyDinh.SelectedIndex>=0)
            {
                QuyDinh quyDinh = DanhSachQD[combQuyDinh.SelectedIndex];
                quyDinh.NoiDungQuyDinh = txtNoiDungQDMoi.Text;
                QuyDinhDAO adapterQD = new QuyDinhDAO();
                if (adapterQD.ThayDoiQuyDinh(quyDinh))
                {
                    MessageBox.Show("Đã cập nhật!");
                    txtNoiDungQDMoi.Clear();
                    lbQuyDinhCu.Text = quyDinh.NoiDungQuyDinh;
                }
                else
                {
                    MessageBox.Show("Hệ thống bị lỗi!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuyDinhDAO adapterQD = new QuyDinhDAO();
            QuyDinh quyDinh = DanhSachQD[combQuyDinhXoa.SelectedIndex];
            if (adapterQD.XoaQuyDinh(quyDinh))
            {
                MessageBox.Show("Đã xóa quy định!");
                capNhat();
            }
            else
            {
                MessageBox.Show("Hệ thống bị lỗi!");
            }
        }

        private void combQuyDinhXoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            XL_Chon2();
        }

        private void tabItem2_MouseDown(object sender, MouseEventArgs e)
        {
            capNhat();
        }

        private void tabItem3_MouseDown(object sender, MouseEventArgs e)
        {
            capNhat();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

    }
}
