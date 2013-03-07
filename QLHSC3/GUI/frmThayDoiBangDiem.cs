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
    public partial class frmThayDoiBangDiem : DevComponents.DotNetBar.Office2007Form
    {
        Diem[] diem;
        bool flag = false;
        public frmThayDoiBangDiem()
        {
            InitializeComponent();
        }

        private void frmThayDoiBangDiem_Load(object sender, EventArgs e)
        {
            LopDAO adaterLop = new LopDAO();
            HocKiDAO adapterHK = new HocKiDAO();
            MonHocDAO adapterMH = new MonHocDAO();

            if (flag == false)
            {
                combMonHoc.DataSource = adapterMH.getAllMH();
                combMonHoc.DisplayMember = "tenMonHoc";
                combMonHoc.Tag = adapterMH.getAllMH();

                combHK.DataSource = adapterHK.getAllHK();
                combHK.DisplayMember = "tenHocKi";
                combHK.Tag = adapterHK.getAllHK();

                combLop.DataSource = adaterLop.getAllClass();
                combLop.DisplayMember = "tenLop";
                combLop.Tag = adaterLop.getAllClass();
                flag = true;
            }
            XL_Chon();
        }

        private void XL_Chon()
        {
            if (flag == true)
            {
                DiemDAO adapterDiem = new DiemDAO();
                HocSinhDAO adapterHS = new HocSinhDAO();
                if (combHK.Text != "" && combLop.Text != "" && combMonHoc.Text != "" && combHK.SelectedIndex >= 0 && combLop.SelectedIndex >= 0 && combMonHoc.SelectedIndex>=0)
                {
                    int chi_soHK = combHK.SelectedIndex;
                    int chi_soLop = combLop.SelectedIndex;
                    int chi_soMH = combMonHoc.SelectedIndex;
                    HocKi KQHK;
                    MonHoc KQMH;
                    Lop KQL;
                    if (chi_soHK >= 0 && chi_soLop >= 0 && chi_soMH >= 0)
                    {
                        HocKi[] HK = (HocKi[])combHK.Tag;
                        KQHK = HK[chi_soHK];

                        Lop[] Lop = (Lop[])combLop.Tag;
                        KQL = Lop[chi_soLop];

                        MonHoc[] MonHoc = (MonHoc[])combMonHoc.Tag;
                        KQMH = MonHoc[chi_soMH];

                        HocSinh[] HS = adapterHS.getStudentIf(KQL.MaLop, KQMH.MaMonHoc, KQHK.MaHocKi);

                        diem = adapterDiem.getStudentIf(KQL.MaLop, KQMH.MaMonHoc, KQHK.MaHocKi);

                        DataTable dt = new DataTable();

                        dt.Columns.Add("hoTen");
                        dt.Columns.Add("diem15Phut");
                        dt.Columns.Add("diem1Tiet");
                        dt.Columns.Add("diemHocKi");

                        for (int i = 0; i < HS.Length; i++)
                        {
                            DataRow Dong = dt.NewRow();
                            dt.Rows.Add(Dong);
                            Dong["hoTen"] = HS[i].HoTen;
                            Dong["diem15Phut"] = diem[i].Diem15Phut;
                            Dong["diem1Tiet"] = diem[i].Diem1Tiet;
                            Dong["diemHocKi"] = diem[i].DiemHocKi;
                        }
                        dgvBangDiem.DataSource = dt;
                    }

                }
            }
        }

        private void combHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            XL_Chon();
        }

        private void combLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            XL_Chon();
        }

        private void combMonHoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            XL_Chon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int icountSelectRows = dgvBangDiem.SelectedRows.Count;
            int icount = dgvBangDiem.SelectedCells.Count;
            
            

            if (icountSelectRows == 0 && icount==0)
            {
                MessageBox.Show("Bạn hãy chọn dòng cần xóa!");
            }
            else
            {
                foreach (DataGridViewRow dr in dgvBangDiem.Rows)
                {
                    bool state=false;
                    foreach (DataGridViewCell cell in dr.Cells)
                    {
                        if (cell.Selected == true)
                        {
                            state = true;
                        }
                    }
                    if (state == true)
                    {
                        dr.Cells[1].Value = 0;
                        dr.Cells[2].Value = 0;
                        dr.Cells[3].Value = 0;
                    }
                }
                MessageBox.Show("Đã xóa!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow dr in dgvBangDiem.Rows)
            {
                diem[i].Diem15Phut =(float) Convert.ToInt32(dr.Cells[1].Value);
                diem[i].Diem1Tiet = (float) Convert.ToInt32(dr.Cells[2].Value);
                diem[i].DiemHocKi = (float) Convert.ToInt32(dr.Cells[3].Value);
                i++;
            }
            DiemDAO adapterDiem = new DiemDAO();
            if (adapterDiem.UpdateMark(diem))
            {
                MessageBox.Show("Lưu thành công!");
            }
            else
            {
                MessageBox.Show("Hệ thống bị lỗi!");
            }
        }

    }
}
