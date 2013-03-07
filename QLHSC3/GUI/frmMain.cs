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
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        ThongBao[] listThongBao;
        public frmMain()
        {
            InitializeComponent();
        }

        private void LoadTinTuc(int t)
        {
            TinTucDAO adapterTT = new TinTucDAO();
            listThongBao = adapterTT.getAllNews();

            int i = listThongBao.Length-t;
            int k;
            if (i > 10)
            {
                k = 0;
                for (i = listThongBao.Length - 1 - t; i > i - 9 - t; i--)
                {
                    switch (k++)
                    {
                        case 0:
                            linkLabel0.Text = listThongBao[i].TenThongBao;
                            break;
                        case 1:
                            linkLabel1.Text = listThongBao[i].TenThongBao;
                            break;
                        case 2:
                            linkLabel2.Text = listThongBao[i].TenThongBao;
                            break;
                        case 3:
                            linkLabel3.Text = listThongBao[i].TenThongBao;
                            break;
                        case 4:
                            linkLabel4.Text = listThongBao[i].TenThongBao;
                            break;
                        case 5:
                            linkLabel5.Text = listThongBao[i].TenThongBao;
                            break;
                        case 6:
                            linkLabel6.Text = listThongBao[i].TenThongBao;
                            break;
                        case 7:
                            linkLabel7.Text = listThongBao[i].TenThongBao;
                            break;
                        case 8:
                            linkLabel8.Text = listThongBao[i].TenThongBao;
                            break;
                        case 9:
                            linkLabel9.Text = listThongBao[i].TenThongBao;
                            break;
                    }
                }
            }
            else
            {
                k = 0;
                for (i = listThongBao.Length - 1; i >= 0; i--)
                {
                    switch (k++)
                    {
                        case 0:
                            linkLabel0.Text = listThongBao[i].TenThongBao;
                            break;
                        case 1:
                            linkLabel1.Text = listThongBao[i].TenThongBao;
                            break;
                        case 2:
                            linkLabel2.Text = listThongBao[i].TenThongBao;
                            break;
                        case 3:
                            linkLabel3.Text = listThongBao[i].TenThongBao;
                            break;
                        case 4:
                            linkLabel4.Text = listThongBao[i].TenThongBao;
                            break;
                        case 5:
                            linkLabel5.Text = listThongBao[i].TenThongBao;
                            break;
                        case 6:
                            linkLabel6.Text = listThongBao[i].TenThongBao;
                            break;
                        case 7:
                            linkLabel7.Text = listThongBao[i].TenThongBao;
                            break;
                        case 8:
                            linkLabel8.Text = listThongBao[i].TenThongBao;
                            break;
                        case 9:
                            linkLabel9.Text = listThongBao[i].TenThongBao;
                            break;
                    }
                }
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (BienToanCuc.loai_nguoi_dung)
            {
                    
                case 1:// giao vu
                    ribbonHS.Visible = false;
                    ribbonBGH.Visible = false;
                    ribbonGV.Visible = false;
                    ribbonGVu.Visible = true;
                    //LoadTinTuc(0);
                    break;
                case 2:// giao vien
                    ribbonHS.Visible = false;
                    ribbonBGH.Visible = false;
                    ribbonGV.Visible = true;
                    ribbonGVu.Visible = false;
                    break;
                case 3: // hoc sinh
                    ribbonHS.Visible = true;
                    ribbonBGH.Visible = false;
                    ribbonGV.Visible = false;
                    ribbonGVu.Visible = false;
                    break;
                case 4:// ban giam hieu
                    ribbonHS.Visible = false;
                    ribbonBGH.Visible = true;
                    ribbonGV.Visible = false;
                    ribbonGVu.Visible = false;
                    break;
            }
           
        }

        private void linkLabel0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupTieuDeTin.Visible = false;
            lbTieuDe.Text = listThongBao[0].TenThongBao;
            lbBanTin.Text = listThongBao[0].TenThongBao;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupTieuDeTin.Visible = false;
            lbTieuDe.Text = listThongBao[1].TenThongBao;
            lbBanTin.Text = listThongBao[1].TenThongBao;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupTieuDeTin.Visible = false;
            lbTieuDe.Text = listThongBao[2].TenThongBao;
            lbBanTin.Text = listThongBao[2].TenThongBao;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupTieuDeTin.Visible = false;
            lbTieuDe.Text = listThongBao[3].TenThongBao;
            lbBanTin.Text = listThongBao[3].TenThongBao;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupTieuDeTin.Visible = false;
            lbTieuDe.Text = listThongBao[4].TenThongBao;
            lbBanTin.Text = listThongBao[4].TenThongBao;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupTieuDeTin.Visible = false;
            lbTieuDe.Text = listThongBao[5].TenThongBao;
            lbBanTin.Text = listThongBao[5].TenThongBao;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupTieuDeTin.Visible = false;
            lbTieuDe.Text = listThongBao[6].TenThongBao;
            lbBanTin.Text = listThongBao[6].TenThongBao;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupTieuDeTin.Visible = false;
            lbTieuDe.Text = listThongBao[7].TenThongBao;
            lbBanTin.Text = listThongBao[7].TenThongBao;
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupTieuDeTin.Visible = false;
            lbTieuDe.Text = listThongBao[8].TenThongBao;
            lbBanTin.Text = listThongBao[8].TenThongBao;
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupTieuDeTin.Visible = false;
            lbTieuDe.Text = listThongBao[9].TenThongBao;
            lbBanTin.Text = listThongBao[9].TenThongBao;
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupTieuDeTin.Visible = true;
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadTinTuc(-10);
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadTinTuc(10);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            LoadTinTuc(0);
        }

        #region Các chức năng của giáo vụ
        private void btnThayDHSHS_GV_Click(object sender, EventArgs e)
        {
            frmTiepNhanHocSinh frmtiepnhanhocsinh_gv = new frmTiepNhanHocSinh();
            frmtiepnhanhocsinh_gv.ShowDialog();
        }

        private void btnThayDDSL_GVu_Click_1(object sender, EventArgs e)
        {
            frmLapDanhSachLop frmlapdanhsachlop = new frmLapDanhSachLop();
            frmlapdanhsachlop.ShowDialog();
        }
        private void btnThayDBD_GVu_Click(object sender, EventArgs e)
        {
            frmThayDoiBangDiem frmthaydoibangdiem = new frmThayDoiBangDiem();
            frmthaydoibangdiem.ShowDialog();
        }
        private void btnLapTB_GVu_Click(object sender, EventArgs e)
        {
            frmLapThongBao frmlapthongbao = new frmLapThongBao();
            frmlapthongbao.ShowDialog();
        }
        private void btnXemTB_GVu_Click(object sender, EventArgs e)
        {
            frmXemThongBao frmxemthongbao = new frmXemThongBao();
            frmxemthongbao.ShowDialog();
        }
        private void btnLapBCTKM_GVu_Click(object sender, EventArgs e)
        {
            frmBaoCaoTongKetMon frm = new frmBaoCaoTongKetMon();
            frm.ShowDialog();
        }
        private void btnLapBCTKHK_GVu_Click(object sender, EventArgs e)
        {
            frmBaoCaoTongKetHocKi frm = new frmBaoCaoTongKetHocKi();
            frm.ShowDialog();
        }
        private void btnLapTKB_GVu_Click(object sender, EventArgs e)
        {
            frmLapThoiKhoaBieu frmlapthoikhoabieu = new frmLapThoiKhoaBieu();
            frmlapthoikhoabieu.ShowDialog();
        }
        private void btnXemTKB_GVu_Click(object sender, EventArgs e)
        {
            frmXemThoiKhoaBieu frmxemthoikhoabieu = new frmXemThoiKhoaBieu();
            frmxemthoikhoabieu.ShowDialog();
        }
        private void btbTraCHS_GVu_Click(object sender, EventArgs e)
        {
            frmTraCuuHocSinh frmtracuu_hs = new frmTraCuuHocSinh();
            frmtracuu_hs.ShowDialog();
        }
        private void btnXemBD_GVu_Click(object sender, EventArgs e)
        {

        }
#endregion
        #region Các chức năng của học sinh
        private void btnXemD_HSinh_Click(object sender, EventArgs e)
        {

        }
        private void btnXemTTCN_HSinh_Click(object sender, EventArgs e)
        {

        }
        private void btnXemTB_HSinh_Click(object sender, EventArgs e)
        {
            frmXemThongBao frmxemthongbao_hs = new frmXemThongBao();
            frmxemthongbao_hs.ShowDialog();
        }
        private void btnXemTKB_HSinh_Click(object sender, EventArgs e)
        {
            frmXemThoiKhoaBieu frmxemthoikhoabieu_hs = new frmXemThoiKhoaBieu();
            frmxemthoikhoabieu_hs.ShowDialog();
        }
        #endregion
        #region Các chức năng của giáo viên
        private void btnThayDBD_GVien_Click(object sender, EventArgs e)
        {

        }
        private void btnTraCuu_GVien_Click(object sender, EventArgs e)
        {
            frmTraCuuHocSinh frmtracuu_hs = new frmTraCuuHocSinh();
            frmtracuu_hs.ShowDialog();
        }
        private void btnXemBD_GVien_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Các chức năng của ban giám hiệu
        private void btnXemBCTKHK_BGHieu_Click(object sender, EventArgs e)
        {
            frmBaoCaoTongKetHocKi frm = new frmBaoCaoTongKetHocKi();
            frm.ShowDialog();
        }
        private void btnXemBCTKM_BGHieu_Click(object sender, EventArgs e)
        {
            frmBaoCaoTongKetMon frm = new frmBaoCaoTongKetMon();
            frm.ShowDialog();
        }
        #endregion







    }
}
