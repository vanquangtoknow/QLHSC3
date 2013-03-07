using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHSC3.XML;
using QLHSC3.BUS;
using QLHSC3.DTO;
namespace QLHSC3.GUI
{
    public partial class frmLapThoiKhoaBieu : DevComponents.DotNetBar.Office2007Form
    {
        private XL_XML xuly_xml = new XL_XML();
        private LopBUS lopBUS = new LopBUS();
        public frmLapThoiKhoaBieu()
        {
            InitializeComponent();
        }
        public MonHocXml[] layDSMonHoc_Tu_GUI()
        {
            List<MonHocXml> listMonHoc = new List<MonHocXml>();
            for (int i = 0; i < dtgv_ThoiKhoaBieu.Rows.Count - 1; i++)
            {
                for (int j = 2; j <= 7; j++)
                {
                    if (dtgv_ThoiKhoaBieu.Rows[i].Cells[j].Value.ToString().CompareTo("")!=0)
                    {
                        MonHocXml mon = new MonHocXml();
                        switch (j)
                        {
                            case 2:
                                mon.TenThu = "2";
                                break;
                            case 3:
                                mon.TenThu = "3";
                                break;
                            case 4:
                                mon.TenThu = "4";
                                break;
                            case 5:
                                mon.TenThu = "5";
                                break;
                            case 6:
                                mon.TenThu = "6";
                                break;
                            case 7:
                                mon.TenThu = "7";
                                break;

                        }
                        mon.TenMon = dtgv_ThoiKhoaBieu.Rows[i].Cells[j].Value.ToString();
                        if (i <= 4)
                        {
                            mon.TenBuoi = "Sáng";
                        }
                        else
                        {
                            mon.TenBuoi = "Chiều";
                        }
                        mon.Tiet = i + 1;
                        listMonHoc.Add(mon);
                    }
                }
            }
            MonHocXml[] dsMonHoc = listMonHoc.ToArray();
            return dsMonHoc;
        }
        private void frmLapThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            Lop[] dsLop = lopBUS.layDanhSachLop_BUS();
            comboLop.Tag = dsLop;
            comboLop.DataSource = dsLop;
            comboLop.ValueMember = "maLop";
            comboLop.DisplayMember = "tenLop";
            int maLop = 1;
            DataTable table = taoBangThoiKhoaBieu(maLop);
            dtgv_ThoiKhoaBieu.DataSource = table;
        }
        private DataTable taoBangThoiKhoaBieu(int maLop)
        {
            DataTable table = new DataTable();
            table.Columns.Add("tiet");
            table.Columns.Add("buoi");
            table.Columns.Add("thu2");
            table.Columns.Add("thu3");
            table.Columns.Add("thu4");
            table.Columns.Add("thu5");
            table.Columns.Add("thu6");
            table.Columns.Add("thu7");
            for (int i = 0; i < 10; i++)
            {
                DataRow row = table.NewRow();
                row["tiet"] = i + 1;
                if (i == 0)
                {
                    row["buoi"] = "Sáng";
                }
                if (i == 5)
                {
                    row["buoi"] = "Chiều";
                }
                table.Rows.Add(row);
            }
            MonHocXml[] Ds_monhoc = xuly_xml.layDanhSachMonHoc(maLop);
            for (int i = 0; i < Ds_monhoc.Length; i++)
            {
                switch (Ds_monhoc[i].TenThu)
                {
                    case "2":
                        table.Rows[Ds_monhoc[i].Tiet - 1]["thu2"] = Ds_monhoc[i].TenMon;
                        break;
                    case "3":
                        table.Rows[Ds_monhoc[i].Tiet - 1]["thu3"] = Ds_monhoc[i].TenMon;
                        break;
                    case "4":
                        table.Rows[Ds_monhoc[i].Tiet - 1]["thu4"] = Ds_monhoc[i].TenMon;
                        break;
                    case "5":
                        table.Rows[Ds_monhoc[i].Tiet - 1]["thu5"] = Ds_monhoc[i].TenMon;
                        break;
                    case "6":
                        table.Rows[Ds_monhoc[i].Tiet - 1]["thu6"] = Ds_monhoc[i].TenMon;
                        break;
                    case "7":
                        table.Rows[Ds_monhoc[i].Tiet - 1]["thu7"] = Ds_monhoc[i].TenMon;
                        break;
                }
            }
            return table;
        }

        private void comboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboLop.SelectedIndex;
            Lop[] dsLop = (Lop[])comboLop.Tag;
            dtgv_ThoiKhoaBieu.DataSource = taoBangThoiKhoaBieu(dsLop[index].MaLop);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            dtgv_ThoiKhoaBieu.ReadOnly = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            MonHocXml[] dsMon = layDSMonHoc_Tu_GUI();
            int index = comboLop.SelectedIndex;
            Lop[] dsLop = (Lop[])comboLop.Tag;
            DialogResult dlg = MessageBox.Show("Bạn có muốn lưu hay không?", "Lưu", MessageBoxButtons.OKCancel);
            if (dlg == DialogResult.OK)
            {
                xuly_xml.taoThoiKhoaBieu(dsLop[index].MaLop, dsMon);
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                dtgv_ThoiKhoaBieu.ReadOnly = true;
            }
            else
            {
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có muốn đóng hay không?", "Close", MessageBoxButtons.OKCancel);
            if (dlg == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
