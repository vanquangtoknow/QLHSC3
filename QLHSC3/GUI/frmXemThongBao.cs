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
    public partial class frmXemThongBao : DevComponents.DotNetBar.Office2007Form
    {
        public frmXemThongBao()
        {
            InitializeComponent();
        }
        private ThongBaoBUS thongbao_BUS = new ThongBaoBUS();
        private void NhanPhieuMoi_Load(object sender, EventArgs e)
        {

            ThongBao[] dsThongBao = thongbao_BUS.layTatCaThongBao_BUS();
            for (int i = 0; i < dsThongBao.Length; i++)
            {
                ListViewItem ten = new ListViewItem(dsThongBao[i].TenThongBao);
                ListViewItem.ListViewSubItem noidung = new ListViewItem.ListViewSubItem(ten, dsThongBao[i].NoiDungThongBao);
                ListViewItem.ListViewSubItem ngay = new ListViewItem.ListViewSubItem(ten, dsThongBao[i].NgayThongBao.ToShortDateString());

                ten.SubItems.Add(noidung);
                ten.SubItems.Add(ngay);
                lvThongBao.Items.Add(ten);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            DialogResult dlg = MessageBox.Show("Bạn có muốn đóng hay không?", "Close", MessageBoxButtons.OKCancel);
            if (dlg == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
