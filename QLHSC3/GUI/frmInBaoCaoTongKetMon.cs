using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QLHSC3.DTO;

namespace QLHSC3
{
    public partial class frmInBaoCaoTongKetMon : Form
    {
        BaoCaoTongKetMon[] Danh_Sach;
        string tenMonHoc;
        string tenHocKi;

        public frmInBaoCaoTongKetMon(BaoCaoTongKetMon[] DS, string mh, string hk)
        {
            Danh_Sach = DS;
            tenHocKi = hk;
            tenMonHoc = mh;
            InitializeComponent();
        }


        private void frmInBaoCaoTongKetMon_Load(object sender, EventArgs e)
        {   
            string time = DateTime.Now.Date.ToString();
            List<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("TenMonHoc", tenMonHoc));
            param.Add(new ReportParameter("HocKi", tenHocKi));
            param.Add(new ReportParameter("ThoiGian",time));
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
