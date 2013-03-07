using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHSC3.BUS;
using QLHSC3.DTO;

namespace QLHSC3.GUI
{
    public partial class frmTraCuuHocSinh : DevComponents.DotNetBar.Office2007Form
    {
        private TraCuuBUS tracuu = new TraCuuBUS();
        private LopBUS lop = new LopBUS();
        private HocSinhBUS hocsinh = new HocSinhBUS();
        public frmTraCuuHocSinh()
        {
            InitializeComponent();
        }

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
            Lop[] dsLop = lop.layDanhSachLop_BUS();
            Lop[] dsNew = new Lop[dsLop.Length+1];
            Lop lop_all = new Lop();
            lop_all.TenLop = "All";
            dsNew[0] = lop_all;
            for (int i = 1; i < dsNew.Length; i++)
            {
                dsNew[i] = dsLop[i - 1];
            }
            comboLop.Tag = dsNew;
            comboLop.DataSource = dsNew;
            comboLop.DisplayMember = "tenLop";
            comboLop.ValueMember = "maLop";
            
            //------------------Lấy danh sách học sinh
            HocSinh[] dsHocSinh = hocsinh.layDanhSachHocSinh_BUS();
            comboHoTen.Tag = dsHocSinh;
            comboHoTen.DataSource = dsHocSinh;
            comboHoTen.DisplayMember = "hoTen";
            comboHoTen.SelectedIndex = -1;
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string chuoi = comboLop.SelectedIndex + "]";
            if (tbxMaHocSinh.Text.CompareTo("") == 0)
            {
                chuoi += "0";
            }
            else
            {
                chuoi += tbxMaHocSinh.Text;
            }
            HocSinh[] dsHocSinhSearch = tracuu.traCuuHocSinh_BUS(chuoi, 1);
            dtgvHocSinh.DataSource = chuyenQuaBang_HocSinh(dsHocSinhSearch);
            if (dsHocSinhSearch.Length > 0)
            {
                lbKQ.Text = (dsHocSinhSearch.Length).ToString();
            }
            else
            {
                lbKQ.Text = "0";
            }
            comboHoTen.SelectedIndex = -1;
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
            table.Columns.Add("lop");
            for (int i = 0; i < dsHocSinh.Length; i++)
            {
                DataRow row = table.NewRow();
                row["stt"] = i + 1;
                row["hoTen"] = dsHocSinh[i].HoTen;
                row["maHocSinh"] = dsHocSinh[i].MaHocSinh;
                string tenLop = lop.layTenLop_Tu_MaLop_BUS(dsHocSinh[i].MaLop);
                if (tenLop!= null)
                {
                    row["lop"] = tenLop;
                }
                else
                {
                    row["lop"] = "Non";
                }
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
        private void comboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lop[] dsLop = (Lop[])comboLop.Tag;
            int index_Lop = comboLop.SelectedIndex;
            string tenGiaoVien;
            if (index_Lop > 0)
            {
                tenGiaoVien = lop.layTenGiaoVien_Tu_MaLop_BUS(index_Lop);
            }
            else
            {
                tenGiaoVien = "";
            }
            lbTenGiaoVien.Text = tenGiaoVien;
            string chuoi = comboLop.SelectedIndex + "]";
            if (tbxMaHocSinh.Text.CompareTo("") == 0)
            {
                chuoi += "0";
            }
            else
            {
                chuoi += tbxMaHocSinh.Text;
            }
            HocSinh[] dsHocSinh = tracuu.traCuuHocSinh_BUS(chuoi, 1);
            dtgvHocSinh.DataSource = chuyenQuaBang_HocSinh(dsHocSinh);
            if (dsHocSinh.Length > 0)
            {
                lbKQ.Text = (dsHocSinh.Length).ToString();
            }
            else
            {
                lbKQ.Text = "0";
            }
        }
        private void comboHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HocSinh[] dsHocSinh = (HocSinh[])comboHoTen.Tag;
                int index = comboHoTen.SelectedIndex;
                string chuoi = comboLop.SelectedIndex + "]";
                chuoi += dsHocSinh[index].MaHocSinh.ToString();
                HocSinh[] dsHocSinhSearch = tracuu.traCuuHocSinh_BUS(chuoi, 1);
                dtgvHocSinh.DataSource = chuyenQuaBang_HocSinh(dsHocSinhSearch);
                if (dsHocSinhSearch.Length > 0)
                {
                    lbKQ.Text = (dsHocSinhSearch.Length).ToString();
                }
                else
                {
                    lbKQ.Text = "0";
                }
            }
            comboHoTen.SelectedIndex = -1;
        }

        
        private void buttonX4_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có muốn đóng hay không?", "Close", MessageBoxButtons.OKCancel);
            if (dlg == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
