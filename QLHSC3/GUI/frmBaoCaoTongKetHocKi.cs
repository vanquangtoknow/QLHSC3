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
    public partial class frmBaoCaoTongKetHocKi : DevComponents.DotNetBar.Office2007Form
    {
        bool flag = false;
        string hocKi;
        BaoCaoTongKetMon[] noiDungBaoCao;
        public frmBaoCaoTongKetHocKi()
        {
            InitializeComponent();
        }

        private void frmBaoCaoTongKetHocKi_Load(object sender, EventArgs e)
        {
            HocKiDAO adapterHK = new HocKiDAO();
            if (flag == false)
            {
                combHocKi.DataSource = adapterHK.getAllHK();
                combHocKi.DisplayMember = "tenHocKi";
                combHocKi.Tag = adapterHK.getAllHK();
                flag = true;
            }
            capNhat();
        }

        private void capNhat()
        {
            if (flag == true)
            {
                LopDAO adapterDAO = new LopDAO();
                Lop[] Danh_Sach_Lop = adapterDAO.getAllClass();

                int chi_soHK = combHocKi.SelectedIndex;

                if (chi_soHK >= 0)
                {
                    HocKi[] HK = (HocKi[])combHocKi.Tag;
                    HocKi KQHK = HK[chi_soHK];
                    hocKi = KQHK.TenHocKi;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Stt");
                    dt.Columns.Add("tenLop");
                    dt.Columns.Add("siSo");
                    dt.Columns.Add("soLuongDat");
                    dt.Columns.Add("tiLe");
                    int stt = 0;
                    int i = 0;
                    noiDungBaoCao = new BaoCaoTongKetMon[Danh_Sach_Lop.Length];
                    foreach (Lop lop in Danh_Sach_Lop)
                    {
                        BaoCaoTongKetMon temp = new BaoCaoTongKetMon();
                        DataRow dr = dt.NewRow();
                        dt.Rows.Add(dr);
                        temp.Stt = stt;
                        dr["Stt"] = stt++;
                        dr["tenLop"] = lop.TenLop;
                        dr["siSo"] = lop.SiSo;
                        int soLuongDat = adapterDAO.soLuongDatHocKi(KQHK.MaHocKi,lop.MaLop);
                        dr["soLuongDat"] = soLuongDat;
                        dr["tiLe"] = (float)soLuongDat / lop.SiSo * 100 + "%";
                        temp.TenLop = lop.TenLop;
                        temp.SiSo = lop.SiSo;
                        temp.SoLuongDat = soLuongDat;
                        temp.TiLe = (float)soLuongDat / lop.SiSo * 100 + "%";

                        noiDungBaoCao[i] = temp;
                        i++;
                    }
                    dgvBaoCao.DataSource = dt;
                }
            }
        }

        private void combHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            capNhat();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmInBaoCaoTongKetHocKi frm = new frmInBaoCaoTongKetHocKi(noiDungBaoCao, hocKi);
            frm.Show();
        }
    }
}
