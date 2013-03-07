using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHSC3.DTO;
using QLHSC3.BUS;

namespace QLHSC3
{
    public partial class frmTiepNhanHocSinh : DevComponents.DotNetBar.Office2007Form
    {
        private bool static_sua = false;
        private HocSinhBUS hocsinhBUS = new HocSinhBUS();
        public frmTiepNhanHocSinh()
        {
            InitializeComponent();
        }
        public void set_GUI_Tu_GridView(string diachi, string hoten, string email, DateTime ngaysinh, bool gioitinh)
        {
            tbxDiaChi.Text = diachi;
            tbxEmail.Text = email;
            tbxHoTen.Text = hoten;
            dtimeNgaySinh.Value = ngaysinh;
            if (gioitinh == true)
            {
                rdioNam.Checked = true;
                rdioNu.Checked = false;
            }
            else
            {
                rdioNam.Checked = false;
                rdioNu.Checked = true;
            }
        }
        public void reset_GUI()
        {
            tbxEmail.Text = "";
            tbxHoTen.Text = "";
            tbxDiaChi.Text = "";
        }
        public HocSinh layHocSinh_Tu_GUI()
        {
            HocSinh hocsinh = new HocSinh(); ;
            if (tbxDiaChi.Text.CompareTo("")!= 0 || tbxHoTen.Text.CompareTo("")!= 0 || tbxEmail.Text.CompareTo("")!=0)
            {
                hocsinh.HoTen = tbxHoTen.Text;
                hocsinh.Email = tbxEmail.Text;
                hocsinh.Diachi = tbxDiaChi.Text;
                if (rdioNam.Checked == true)
                {
                    hocsinh.GioiTinh = true;
                }
                else
                {
                    hocsinh.GioiTinh = false;
                }
                hocsinh.NgaySinh = dtimeNgaySinh.Value;
            }
            return hocsinh;
        }
        public DataTable chuyenQuaBang_HocSinh(HocSinh[] dsHocSinh)
        {
            DataTable table = new DataTable();
            table.Columns.Add("stt");
            table.Columns.Add("hoTen");
            table.Columns.Add("maHocSinh");
            table.Columns.Add("gioiTinh");
            table.Columns.Add("ngaySinh");
            table.Columns.Add("diaChi");
            table.Columns.Add("email");
            for (int i = 0; i < dsHocSinh.Length; i++)
            {
                DataRow row = table.NewRow();
                row["stt"] = i + 1;
                row["hoTen"] = dsHocSinh[i].HoTen;
                row["maHocSinh"] = dsHocSinh[i].MaHocSinh;
                if (dsHocSinh[i].GioiTinh == true)
                {
                    row["gioiTinh"] = "Nam";
                }
                else
                {
                    row["gioiTinh"] = "Nữ";
                }
                row["ngaySinh"] = dsHocSinh[i].NgaySinh;
                row["diaChi"] = dsHocSinh[i].Diachi;
                row["email"] = dsHocSinh[i].Email;
                table.Rows.Add(row);
            }
            return table;

        }
        private void frmTiepNhanHocSinh_Load(object sender, EventArgs e)
        {
            HocSinh[] dsHocSinh = hocsinhBUS.layDanhSachHocSinh_BUS();
            DataTable bangHocSinh = chuyenQuaBang_HocSinh(dsHocSinh);
            duaDSHocSinh_GridView(bangHocSinh, dtgvHocSinh);
        }
        private void duaDSHocSinh_GridView(DataTable bangHocSinh, DataGridView dgvHocSinh)
        {
            dgvHocSinh.DataSource = bangHocSinh;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            HocSinh hocsinh = layHocSinh_Tu_GUI();
            if (hocsinh.HoTen != null)
            {
                bool check;
                if (static_sua == true)
                {
                    hocsinh.MaHocSinh = Convert.ToInt32(dtgvHocSinh.CurrentRow.Cells["maHocSinh"].Value);
                    check = hocsinhBUS.suaHocSinh_BUS(hocsinh);
                }
                else
                {
                    check = hocsinhBUS.themHocSinh_BUS(hocsinh);
                }
                if (check == true)
                {
                    MessageBox.Show("Thực hiện thành công");
                    HocSinh[] dsHocSinh = hocsinhBUS.layDanhSachHocSinh_BUS();
                    DataTable bangHocSinh = chuyenQuaBang_HocSinh(dsHocSinh);
                    duaDSHocSinh_GridView(bangHocSinh, dtgvHocSinh);
                    reset_GUI();
                }
                else
                {
                    MessageBox.Show("Thực hiện thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu thông tin \n Vui lòng nhập lại");
            }
            static_sua = false;
        }
        void dtgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            dtgvHocSinh.ReadOnly = false;
            int index = dtgvHocSinh.CurrentRow.Index;
            if (index < dtgvHocSinh.RowCount - 1)
            {
                DataGridViewRow currentRow = dtgvHocSinh.CurrentRow;
                DateTime ngaySinh = DateTime.Parse(currentRow.Cells["ngaySinh"].Value.ToString());
                bool gioiTinh;
                if (currentRow.Cells["gioiTinh"].ToString().CompareTo("Nam") == 0)
                {
                    gioiTinh = true;
                }
                else
                {
                    gioiTinh = false;
                }
                set_GUI_Tu_GridView(currentRow.Cells["diaChi"].Value.ToString(), currentRow.Cells["hoTen"].Value.ToString(), currentRow.Cells["email"].Value.ToString(), ngaySinh, gioiTinh);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            dtgvHocSinh.ReadOnly = false;
            int index = dtgvHocSinh.CurrentRow.Index;
            if (index < dtgvHocSinh.RowCount - 1)
            {
                DataGridViewRow currentRow = dtgvHocSinh.CurrentRow;
                DateTime ngaySinh = DateTime.Parse(currentRow.Cells["ngaySinh"].Value.ToString());
                bool gioiTinh;
                if (currentRow.Cells["gioiTinh"].ToString().CompareTo("Nam") == 0)
                {
                    gioiTinh = true;
                }
                else
                {
                    gioiTinh = false;
                }
                set_GUI_Tu_GridView(currentRow.Cells["diaChi"].Value.ToString(), currentRow.Cells["hoTen"].Value.ToString(), currentRow.Cells["email"].Value.ToString(), ngaySinh, gioiTinh);
                static_sua = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            static_sua = false;
            reset_GUI();
        }
        private void capNhat_GUI()
        {
            HocSinh[] dsHocSinh = hocsinhBUS.layDanhSachHocSinh_BUS();
            DataTable bangHocSinh = chuyenQuaBang_HocSinh(dsHocSinh);
            duaDSHocSinh_GridView(bangHocSinh, dtgvHocSinh);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvHocSinh.CurrentRow.Index < dtgvHocSinh.Rows.Count - 1)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa hay không", "Thoát", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    HocSinh hocsinh = new HocSinh();
                    hocsinh.MaHocSinh = Convert.ToInt32(dtgvHocSinh.CurrentRow.Cells["maHocSinh"].Value);
                    bool check = hocsinhBUS.xoaHocSinh_BUS(hocsinh);
                    if (check == true)
                    {
                        MessageBox.Show("Xóa thành công.");
                        capNhat_GUI();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.");
                    }
                }
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            static_sua = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có muốn đóng hay không?", "Close", MessageBoxButtons.OKCancel);
            if (dlg == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
