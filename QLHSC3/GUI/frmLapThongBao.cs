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

namespace QLHSC3.GUI
{
    public partial class frmLapThongBao : DevComponents.DotNetBar.Office2007Form
    {
        private ThongBaoBUS thongbao_BUS = new ThongBaoBUS();
        public frmLapThongBao()
        {
            InitializeComponent();
        }
        public ThongBao layThongBao_Tu_GUI()
        {
            ThongBao thongbao = new ThongBao();
            thongbao.TenThongBao = tbxTenThongBao.Text;
            thongbao.NoiDungThongBao = tbxNoiDungThongBao.Text;
            thongbao.NgayThongBao = dtNgayThongBao.Value;
            return thongbao;
        }
        public bool kiemtraThongBao_GUI()
        {
            if (tbxNoiDungThongBao.Text.CompareTo("") == 0 || tbxTenThongBao.Text.CompareTo("")==0)
            {
                return false;
            }
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemtraThongBao_GUI() == true)
            {
                ThongBao thongbao = layThongBao_Tu_GUI();
                thongbao_BUS.taoThongBao_BUS(thongbao);
                tbxTenThongBao.Text = "";
                tbxNoiDungThongBao.Text = "";
                lvThongBao.Items.Clear();
                ThongBao[] dsThongBao = thongbao_BUS.layTatCaThongBao_BUS();
                for (int i = 0; i < dsThongBao.Length; i++)
                {
                    ListViewItem ma = new ListViewItem(dsThongBao[i].MaThongBao.ToString());
                    ListViewItem.ListViewSubItem ten = new ListViewItem.ListViewSubItem(ma, dsThongBao[i].TenThongBao);
                    ListViewItem.ListViewSubItem noidung = new ListViewItem.ListViewSubItem(ma, dsThongBao[i].NoiDungThongBao);
                    ListViewItem.ListViewSubItem ngay = new ListViewItem.ListViewSubItem(ma, dsThongBao[i].NgayThongBao.ToShortDateString());
                    ma.SubItems.Add(ten);
                    ma.SubItems.Add(noidung);
                    ma.SubItems.Add(ngay);
                    lvThongBao.Items.Add(ma);
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu thông tin! Vui lòng nhập lại ");
            }
        }

        private void frmLapThongBao_Load(object sender, EventArgs e)
        {
            ThongBao[] dsThongBao = thongbao_BUS.layTatCaThongBao_BUS();
            for (int i = 0; i < dsThongBao.Length; i++)
            {
                ListViewItem ma = new ListViewItem(dsThongBao[i].MaThongBao.ToString());
                ListViewItem.ListViewSubItem ten = new ListViewItem.ListViewSubItem(ma, dsThongBao[i].TenThongBao);
                ListViewItem.ListViewSubItem noidung = new ListViewItem.ListViewSubItem(ma, dsThongBao[i].NoiDungThongBao);
                ListViewItem.ListViewSubItem ngay = new ListViewItem.ListViewSubItem(ma, dsThongBao[i].NgayThongBao.ToShortDateString());
                ma.SubItems.Add(ten);
                ma.SubItems.Add(noidung);
                ma.SubItems.Add(ngay);
                lvThongBao.Items.Add(ma);
            }
        }
        private void lvThongBao_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection breakfast = this.lvThongBao.SelectedItems;
            int maThongBao = 0;
            foreach (ListViewItem item in breakfast)
            {
                maThongBao = Int32.Parse(item.SubItems[0].Text);
            }
            DialogResult dlg = MessageBox.Show("Bạn có muốn xóa thông báo này không?", "Xóa", MessageBoxButtons.OKCancel);
            if (dlg == DialogResult.OK)
            {
                thongbao_BUS.xoaThongBao_MaThongBao_BUS(maThongBao);
                ThongBao thongbao = layThongBao_Tu_GUI();
                tbxTenThongBao.Text = "";
                tbxNoiDungThongBao.Text = "";
                lvThongBao.Items.Clear();
                ThongBao[] dsThongBao = thongbao_BUS.layTatCaThongBao_BUS();
                for (int i = 0; i < dsThongBao.Length; i++)
                {
                    ListViewItem ma = new ListViewItem(dsThongBao[i].MaThongBao.ToString());
                    ListViewItem.ListViewSubItem ten = new ListViewItem.ListViewSubItem(ma, dsThongBao[i].TenThongBao);
                    ListViewItem.ListViewSubItem noidung = new ListViewItem.ListViewSubItem(ma, dsThongBao[i].NoiDungThongBao);
                    ListViewItem.ListViewSubItem ngay = new ListViewItem.ListViewSubItem(ma, dsThongBao[i].NgayThongBao.ToShortDateString());
                    ma.SubItems.Add(ten);
                    ma.SubItems.Add(noidung);
                    ma.SubItems.Add(ngay);
                    lvThongBao.Items.Add(ma);
                }
            }
        }
    }
}
