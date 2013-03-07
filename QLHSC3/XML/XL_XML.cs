using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;
using System.Windows.Forms;
using QLHSC3.DAO;
using QLHSC3.XML;
using System.Data.SqlClient;
using QLHSC3.Common;

namespace QLHSC3
{
    class XL_XML
    {
        

        //Luu tai khoan da dang nhap
        private static string pathXML = "../../DATA/LichSuDangNhap.xml";

        public static XmlElement Doc_goc()
        {
            XmlDocument TRUNG_TAM = new XmlDocument();
            TRUNG_TAM.Load(pathXML);
            return TRUNG_TAM.DocumentElement;
        }

        public static void ThemTKVaoLSDN(string taiKhoan, string matKhau)
        {
            XmlDocument root = new XmlDocument();
            root.Load(pathXML);

            XmlElement Lich_Su = root.DocumentElement;
            if(!KiemTraTaiKhoanTonTaiTrongLSDN(taiKhoan,matKhau))
            {
                XmlElement Tai_Khoan = root.CreateElement("TAI_KHOAN");
                Tai_Khoan.SetAttribute("Ten_Dang_Nhap",taiKhoan);
                Tai_Khoan.SetAttribute("Mat_Khau", matKhau);
                Lich_Su.AppendChild(Tai_Khoan);
                root.Save(pathXML);
            }
        }

        private static bool KiemTraTaiKhoanTonTaiTrongLSDN(string taiKhoan, string matKhau)
        {
            XmlDocument root = new XmlDocument();
            root.Load(pathXML);

            XmlElement Lich_Su = root.DocumentElement;

            XmlNodeList Danh_Sach_Tai_Khoan = Lich_Su.SelectNodes("TAI_KHOAN");
            if (Danh_Sach_Tai_Khoan.Count > 0)
            {
                foreach (XmlNode TK in Danh_Sach_Tai_Khoan)
                {
                    if (taiKhoan.CompareTo(TK.Attributes["Ten_Dang_Nhap"].Value) == 0 && matKhau.CompareTo(TK.Attributes["Mat_Khau"].Value) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static DataTable Tao_Bang(XmlNodeList Danh_sach)
        {
            DataTable Kq = new DataTable();
            if (Danh_sach.Count > 0)
            {
                XmlElement Nut_0 = (XmlElement)Danh_sach[0];
                foreach (XmlAttribute Thuoc_tinh in Nut_0.Attributes)
                {
                    Kq.Columns.Add(Thuoc_tinh.Name);
                }
                foreach (XmlElement Nut in Danh_sach)
                {
                    DataRow Dong = Kq.NewRow();
                    Kq.Rows.Add(Dong);
                    foreach (XmlAttribute Thuoc_tinh in Nut.Attributes)
                    {
                        String Ten_cot = Thuoc_tinh.Name;
                        Dong[Ten_cot] = Nut.GetAttribute(Ten_cot);
                    }
                }
            }
            return Kq;
        }

        public static void Xuat(XmlNodeList Danh_sach, ComboBox comboDanhSach,  String Ten_cot_the_hien = "")
        {
            if (Danh_sach.Count > 0)
            {
                DataTable Bang = Tao_Bang(Danh_sach);
                if (Ten_cot_the_hien == "")
                {
                    Ten_cot_the_hien = Bang.Columns[0].ColumnName;
                }

                comboDanhSach.DisplayMember = Ten_cot_the_hien;
                comboDanhSach.Tag = Danh_sach;
                comboDanhSach.DataSource = Bang;
            }
        }

        public static XmlElement Chon(ComboBox comboDanhSach)
        {
            XmlElement Kq = null;
            int Chi_so = comboDanhSach.SelectedIndex;
            if (Chi_so >= 0)
            {
                XmlNodeList Danh_sach = (XmlNodeList)comboDanhSach.Tag;
                Kq = (XmlElement)Danh_sach[Chi_so];
            }
            return Kq;
        }

        private XmlDocument doc = new XmlDocument();
        private LopDAO lop = new LopDAO();
        public XmlElement docGoc()
        {
            doc.Load("xml.xml");
            return (XmlElement)doc.SelectSingleNode("/ThoiKhoaBieu");
        }
        public MonHocXml[] layDanhSachMonHoc(int maLop)
        {
            if (lop.layThoiKhoaBieu_Tu_MaLop(maLop) != null)
            {
                string e = lop.layThoiKhoaBieu_Tu_MaLop(maLop);
                doc.LoadXml(lop.layThoiKhoaBieu_Tu_MaLop(maLop));
                XmlNode nodeGoc = doc.SelectSingleNode("/ThoiKhoaBieu");
                XmlNodeList dsMon_NodeList = nodeGoc.SelectNodes("//Mon");

                MonHocXml[] dsMon = new MonHocXml[dsMon_NodeList.Count];
                for (int i = 0; i < dsMon_NodeList.Count; i++)
                {
                    MonHocXml mon = new MonHocXml();
                    string a = dsMon_NodeList[i].Attributes["tenMon"].Value.ToString();
                    mon.TenMon = dsMon_NodeList[i].Attributes["tenMon"].Value.ToString();
                    mon.Tiet = Convert.ToInt32(dsMon_NodeList[i].Attributes["tiet"].Value);
                    mon.TenBuoi = dsMon_NodeList[i].Attributes["tenBuoi"].Value.ToString();
                    mon.TenThu = dsMon_NodeList[i].ParentNode.Attributes["tenThu"].Value.ToString();
                    dsMon[i] = mon;
                }
                return dsMon;
            }
            return null;
        }
        public void taoThoiKhoaBieu(int maLop, MonHocXml[] dsMonHoc)
        {

            if (lop.layThoiKhoaBieu_Tu_MaLop(maLop) != null)
            {
                bool[] dsDanhDau = new bool[dsMonHoc.Length];
                ThoiKhoaBieu tkb = new ThoiKhoaBieu();
                for (int i = 0; i < dsMonHoc.Length; i++)
                {
                    if (dsDanhDau[i] == false)
                    {
                        Thu thu = new Thu();
                        thu.TenThu = dsMonHoc[i].TenThu;
                        Mon mon = new Mon();
                        mon.TenBuoi = dsMonHoc[i].TenBuoi;
                        mon.TenMon = dsMonHoc[i].TenMon;
                        mon.Tiet = dsMonHoc[i].Tiet.ToString();
                        thu.DsMon.Add(mon);
                        for (int j = i + 1; j < dsMonHoc.Length; j++)
                        {
                            if (dsMonHoc[i].TenThu.CompareTo(dsMonHoc[j].TenThu) == 0)
                            {
                                Mon mon1 = new Mon();
                                mon1.TenBuoi = dsMonHoc[j].TenBuoi;
                                mon1.TenMon = dsMonHoc[j].TenMon;
                                mon1.Tiet = dsMonHoc[j].Tiet.ToString();
                                thu.DsMon.Add(mon1);
                                dsDanhDau[j] = true;
                            }
                        }
                        tkb.DsThu.Add(thu);
                    }
                }
                XmlDocument tailieu = new XmlDocument();
                XmlElement nodeGoc = tailieu.CreateElement("ThoiKhoaBieu");
                for (int i = 0; i < tkb.DsThu.Count; i++)
                {
                    XmlElement thu = tailieu.CreateElement("Thu");
                    thu.SetAttribute("tenThu", tkb.DsThu[i].TenThu);
                    for (int j = 0; j < tkb.DsThu[i].DsMon.Count; j++)
                    {
                        XmlElement mon = tailieu.CreateElement("Mon");
                        mon.SetAttribute("tenMon", tkb.DsThu[i].DsMon[j].TenMon);
                        mon.SetAttribute("tiet", tkb.DsThu[i].DsMon[j].Tiet);
                        mon.SetAttribute("tenBuoi", tkb.DsThu[i].DsMon[j].TenBuoi);
                        thu.AppendChild(mon);
                    }
                    nodeGoc.AppendChild(thu);
                }
                tailieu.AppendChild(nodeGoc);
                string thoikhoabieu_lop = tailieu.InnerXml;
                string capNhatThoiKhoaBieu_MaLop = "sp_CapNhatThoiKhoaBieu_MaLop";
                SqlParameter para1 = new SqlParameter("@maLop", maLop);
                SqlParameter para2 = new SqlParameter("@thoiKhoaBieu", thoikhoabieu_lop);
                DataProvider.executeStoreProcedureNonQuery(capNhatThoiKhoaBieu_MaLop, para1,para2);
            }
        }
    }
}
