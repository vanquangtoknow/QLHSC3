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
using QLHSC3.BUS;
using QLHSC3.XML;
namespace QLHSC3.GUI
{
    public partial class frmXemThoiKhoaBieu : DevComponents.DotNetBar.Office2007Form
    {
        public frmXemThoiKhoaBieu()
        {
            InitializeComponent();
        }
        private XL_XML xuly_xml = new XL_XML();
        private LopBUS lopBUS = new LopBUS();
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

        private void frmXemThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            Lop[] dsLop = lopBUS.layDanhSachLop_BUS();
            comboLop.Tag = dsLop;
            comboLop.DataSource = dsLop;
            comboLop.ValueMember = "maLop";
            comboLop.DisplayMember = "tenLop";
            int maLop = 1;
            dataGridViewX1.DataSource = taoBangThoiKhoaBieu(maLop);
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboLop.SelectedIndex;
            Lop[] dsLop = (Lop[])comboLop.Tag;
            dataGridViewX1.DataSource = taoBangThoiKhoaBieu(dsLop[index].MaLop);
        }
    }
}
