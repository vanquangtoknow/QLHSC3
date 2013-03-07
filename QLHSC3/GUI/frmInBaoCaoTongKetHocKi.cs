using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHSC3.DTO;
using Microsoft.Reporting.WinForms;

namespace QLHSC3.GUI
{
    public partial class frmInBaoCaoTongKetHocKi : Form
    {
        string hocKi;
        BaoCaoTongKetMon[] Danh_Sach;
        public frmInBaoCaoTongKetHocKi(BaoCaoTongKetMon[] DS, string hk)
        {
            Danh_Sach = DS;
            hocKi = hk;
            InitializeComponent();
        }

        private void frmInBaoCaoTongKetHocKi_Load(object sender, EventArgs e)
        {
            string time = DateTime.Now.Date.ToString();
            List<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("HocKi", hocKi));
            param.Add(new ReportParameter("ThoiGian", time));
            reportViewer1.LocalReport.SetParameters(param);

            BindingList<BaoCaoTongKetMon> baoCao = new BindingList<BaoCaoTongKetMon>();
            foreach (BaoCaoTongKetMon bc in Danh_Sach)
            {
                baoCao.Add(bc);
            }
            BaoCaoTongKetMonBindingSource.DataSource = baoCao;
            this.reportViewer1.RefreshReport();
        }
    }
}
