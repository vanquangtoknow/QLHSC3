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
    public partial class frmLapDanhSachLop : DevComponents.DotNetBar.Office2007Form
    {
        private bool edit = false;
        private LopBUS lopBUS = new LopBUS();
        private HocSinhBUS hocsinhBUS = new HocSinhBUS();
        private HocSinh hocsinh_hientai = new HocSinh();
        public frmLapDanhSachLop()
        {
            InitializeComponent();
        }
        // lấy danh sách học sinh từ màn hình giao dien textbox, combobox
        public HocSinh layHocSinh_Tu_GUI()
        {
            HocSinh hocsinh = new HocSinh(); ;
            int indexHocSinh = combomaHocSinh.SelectedIndex;
            int index = comboLop.SelectedIndex;
            Lop[] dsLop = (Lop[])comboLop.Tag;
            //HocSinh[] dsHocSinh = hocsinhBUS.layDanhSachHocSinh_ChuaCoLop_BUS();
            HocSinh[] dsHocSinh;
            if (edit == true)
            {
                dsHocSinh = new HocSinh[1];
                dsHocSinh[0] = hocsinh_hientai;
            }
            else
            {
                dsHocSinh = hocsinhBUS.layDanhSachHocSinh_ChuaCoLop_BUS();
            }
            hocsinh.MaHocSinh = dsHocSinh[indexHocSinh].MaHocSinh;
            int indexLop = comboLop.SelectedIndex;
            hocsinh.MaLop = dsLop[indexLop].MaLop;
            if (tbxDiaChi.Text.CompareTo("") != 0 || tbxHoTen.Text.CompareTo("") != 0 || tbxEmail.Text.CompareTo("") != 0)
            {
                hocsinh.HoTen = tbxHoTen.Text;
                hocsinh.Email = tbxEmail.Text;
                hocsinh.Diachi = tbxDiaChi.Text;
                if (lbGT.Text.CompareTo("Nam") == 0)
                {
                    hocsinh.GioiTinh = true;
                }
                else
                {
                    hocsinh.GioiTinh = false;
                }
                hocsinh.NgaySinh = DateTime.Parse(lbNS.Text);
            }
            return hocsinh;
        }
        // lấy học sinh từ một dòng của datagridview
        public HocSinh layHocSinh_Tu_DataRowGridView(DataGridViewRow row)
        {
            HocSinh hocsinh = new HocSinh();
            hocsinh.MaHocSinh = Convert.ToInt32(row.Cells["maHocSinh"].Value);
            hocsinh.HoTen = row.Cells["hoTen"].Value.ToString();
            hocsinh.Email = row.Cells["email"].Value.ToString();
            hocsinh.Diachi = row.Cells["diaChi"].Value.ToString();
            hocsinh.NgaySinh = DateTime.Parse(row.Cells["ngaySinh"].Value.ToString());
            if (row.Cells["gioiTinh"].Value.ToString().CompareTo("Nam") == 0)
            {
                hocsinh.GioiTinh = true;
            }
            else
            {
                hocsinh.GioiTinh = false;
            }
            hocsinh.MaLop = hocsinhBUS.layMaLop_TuHocSinh_BUS(hocsinh);
            return hocsinh;
        }
        // từ một danh sách học sinh chuyển qua table để đưa lên giao diện
        public DataTable chuyenQuaBang_HocSinh_DaCoLop(HocSinh[] dsHocSinh)
        {
            DataTable table = new DataTable();
            table.Columns.Add("stt");
            table.Columns.Add("hoTen");
            table.Columns.Add("maHocSinh");
            table.Columns.Add("lop");
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
                row["lop"] = hocsinhBUS.layTenLop_TuHocSinh_BUS(dsHocSinh[i]);
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
        private void frmLapDanhSachLop_Load(object sender, EventArgs e)
        {
            Lop[] dsLop = lopBUS.layDanhSachLop_BUS();
            comboLop.Tag = dsLop;
            comboLop.DataSource = dsLop;
            comboLop.ValueMember = "maLop";
            comboLop.DisplayMember = "tenLop";
            int index = comboLop.SelectedIndex;
            lbSiSo.Text = dsLop[index].SiSo.ToString();
            //----------------------
            HocSinh[] dsHocSinh_DaCoLop = hocsinhBUS.layDanhSachHocSinh_DaCoLop_BUS(dsLop[0]);
            DataTable bang = chuyenQuaBang_HocSinh_DaCoLop(dsHocSinh_DaCoLop);
            dtgvHocSinh.DataSource = bang;
            //----------------------
            HocSinh[] dsHocSinh_ChuaCoLop = hocsinhBUS.layDanhSachHocSinh_ChuaCoLop_BUS();
            combomaHocSinh.DataSource = dsHocSinh_ChuaCoLop;
            combomaHocSinh.ValueMember = "maHocSinh";
            combomaHocSinh.DisplayMember = "maHocSinh";

            if (dsHocSinh_ChuaCoLop.Length == 0)
            {
                btnThem.Enabled = false;
            }
            
        }
        private void comboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboLop.SelectedIndex;
            Lop[] dsLop = (Lop[])comboLop.Tag;
            lbSiSo.Text = dsLop[index].SiSo.ToString();
            HocSinh[] dsHocSinh_DaCoLop = hocsinhBUS.layDanhSachHocSinh_DaCoLop_BUS(dsLop[index]);
            DataTable bang = chuyenQuaBang_HocSinh_DaCoLop(dsHocSinh_DaCoLop);
            dtgvHocSinh.DataSource = bang;

        }
        private void combomaHocSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            HocSinh[] dsHocSinh;
            if (edit == false)
            {
                dsHocSinh = hocsinhBUS.layDanhSachHocSinh_ChuaCoLop_BUS();
            }
            else
            {
                dsHocSinh = new HocSinh[1];
                dsHocSinh[0] = hocsinh_hientai;
            }
            int index = combomaHocSinh.SelectedIndex;
            if (index != -1)
            {
                duaThongTinHocSinh_GUI(dsHocSinh[index]);
            }
            else
            {
                if (index == -1)
                {
                    btnThem.Enabled = false;
                }
            }
            
        }
        //đưa các thông tin vào giao diện textbox, datetime
        public void duaThongTinHocSinh_GUI(HocSinh hocsinh)
        {
            tbxDiaChi.Text = hocsinh.Diachi;
            tbxEmail.Text = hocsinh.Email;
            tbxHoTen.Text = hocsinh.HoTen;
            lbNS.Text = hocsinh.NgaySinh.ToShortDateString();
            if (hocsinh.GioiTinh == true)
            {
                lbGT.Text = "Nam";
            }
            else
            {
                lbGT.Text = "Nữ";
            }
        }
        // lấy danh sách từ gridview đưa lên GUI
        public void duaLenGUI_TuGridView()
        {
            int indexRow = dtgvHocSinh.CurrentRow.Index;
            if (indexRow < dtgvHocSinh.RowCount - 1)
            {
                HocSinh hocsinh = layHocSinh_Tu_DataRowGridView(dtgvHocSinh.CurrentRow);
                tbxDiaChi.Text = hocsinh.Diachi;
                tbxEmail.Text = hocsinh.Email;
                tbxHoTen.Text = hocsinh.HoTen;
                if (hocsinh.GioiTinh == true)
                {
                    lbGT.Text = "Nam";
                }
                else
                {
                    lbGT.Text = "Nữ";
                }
                lbNS.Text = hocsinh.NgaySinh.ToShortDateString();
                HocSinh[] dsHs = new HocSinh[1];
                dsHs[0] = hocsinh;
                hocsinh_hientai = hocsinh;
                combomaHocSinh.DataSource = dsHs;
                combomaHocSinh.DisplayMember = "maHocSinh";
                combomaHocSinh.ValueMember = "maHocSinh";
            }
        }
        // Thêm học sinh vào lớp sau đó load lại danh sách học sinh trong lớp đó
        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hocsinh = layHocSinh_Tu_GUI();
            int index = comboLop.SelectedIndex;
            Lop[] dsLop = (Lop[])comboLop.Tag;
            bool check = hocsinhBUS.themHocSinh_VaoLop_BUS(hocsinh, dsLop[index]);
            if (check == true)
            {
                //--- Load lại danh sách học sinh đã có lớp
                HocSinh[] dsHocSinh_DaCoLop = hocsinhBUS.layDanhSachHocSinh_DaCoLop_BUS(dsLop[index]);
                DataTable bang = chuyenQuaBang_HocSinh_DaCoLop(dsHocSinh_DaCoLop);
                dtgvHocSinh.DataSource = bang;
                //-- Load lại danh sách học sinh chưa có lớp
                HocSinh[] dsHocSinh_ChuaCoLop = hocsinhBUS.layDanhSachHocSinh_ChuaCoLop_BUS();
                if (dsHocSinh_ChuaCoLop.Length != 0)
                {
                    combomaHocSinh.DataSource = dsHocSinh_ChuaCoLop;
                    combomaHocSinh.ValueMember = "maHocSinh";
                }
                else
                {
                    tbxDiaChi.Text = "";
                    tbxEmail.Text = "";
                    tbxHoTen.Text = "";
                    combomaHocSinh.DataSource = null;
                }
                //combomaHocSinh.DisplayMember = "maHocSinh";
            }
            else
            {
                int soluong_max = lopBUS.laySoLuongHocSinhToiDa_TrongMotLop_BUS(hocsinh.MaLop);
                MessageBox.Show("Vượt quá số lượng tối đa: " + soluong_max);
            }
        }
        // Xóa hoc sinh của lớp được chọn sau đó load lại comboLop
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvHocSinh.CurrentRow.Index < dtgvHocSinh.Rows.Count - 1)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa hay không", "Thoát", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    HocSinh hocsinh = layHocSinh_Tu_DataRowGridView(dtgvHocSinh.CurrentRow);
                    bool check = hocsinhBUS.xoaHocSinh_RaKhoiLop_BUS(hocsinh);
                    if (check == true)
                    {
                        MessageBox.Show("Xóa thành công.");
                        //-- Load lại danh sách lớp hiện tại
                        Lop[] dsLop = (Lop[])comboLop.Tag;
                        int index = comboLop.SelectedIndex;
                        HocSinh[] dsHocSinh_DaCoLop = hocsinhBUS.layDanhSachHocSinh_DaCoLop_BUS(dsLop[index]);
                        DataTable bang = chuyenQuaBang_HocSinh_DaCoLop(dsHocSinh_DaCoLop);
                        dtgvHocSinh.DataSource = bang;
                        //-- Load lại danh sách học sinh chưa có lớp
                        HocSinh[] dsHocSinh_ChuaCoLop = hocsinhBUS.layDanhSachHocSinh_ChuaCoLop_BUS();
                        combomaHocSinh.DataSource = dsHocSinh_ChuaCoLop;
                        combomaHocSinh.ValueMember = "maHocSinh";
                        combomaHocSinh.DisplayMember = "maHocSinh";
                        if (dsHocSinh_ChuaCoLop.Length > 0)
                        {
                            btnThem.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            edit = true;
            duaLenGUI_TuGridView();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int index = comboLop.SelectedIndex;
            Lop[] dsLop = (Lop[])comboLop.Tag;
            HocSinh hocsinh = layHocSinh_Tu_GUI();
            bool check = hocsinhBUS.suaHocSinh_SuaLop_DAO(hocsinh, dsLop[index]);
            if (check == true)
            {
                MessageBox.Show("Thực hiện thành công");
            }
            else
            {
                MessageBox.Show("Thất bại! Vui lòng nhập lại");
            }
            edit = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            HocSinh[] dsHocSinh_ChuaCoLop = hocsinhBUS.layDanhSachHocSinh_ChuaCoLop_BUS();
            combomaHocSinh.DataSource = dsHocSinh_ChuaCoLop;
            combomaHocSinh.ValueMember = "maHocSinh";
            combomaHocSinh.DisplayMember = "maHocSinh";
            if (dsHocSinh_ChuaCoLop.Length != 0)
            {
                combomaHocSinh.DataSource = dsHocSinh_ChuaCoLop;
                combomaHocSinh.ValueMember = "maHocSinh";
                btnThem.Enabled = true;
            }
            else
            {
                tbxDiaChi.Text = "";
                tbxEmail.Text = "";
                tbxHoTen.Text = "";
                combomaHocSinh.DataSource = null;
                btnThem.Enabled = false;
            }
            //-- load lại danh sách lớp hiện tại
            HocSinh[] dsHocSinh_DaCoLop = hocsinhBUS.layDanhSachHocSinh_DaCoLop_BUS(dsLop[index]);
            DataTable bang = chuyenQuaBang_HocSinh_DaCoLop(dsHocSinh_DaCoLop);
            dtgvHocSinh.DataSource = bang;

        }
        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            edit = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            HocSinh[] dsHocSinh_ChuaCoLop = hocsinhBUS.layDanhSachHocSinh_ChuaCoLop_BUS();
            combomaHocSinh.DataSource = dsHocSinh_ChuaCoLop;
            combomaHocSinh.ValueMember = "maHocSinh";
            combomaHocSinh.DisplayMember = "maHocSinh";
            if (dsHocSinh_ChuaCoLop.Length != 0)
            {
                combomaHocSinh.DataSource = dsHocSinh_ChuaCoLop;
                combomaHocSinh.ValueMember = "maHocSinh";
                btnThem.Enabled = true;
            }
            else
            {
                tbxDiaChi.Text = "";
                tbxEmail.Text = "";
                tbxHoTen.Text = "";
                combomaHocSinh.DataSource = null;
            }

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
