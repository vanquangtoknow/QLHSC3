using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLHSC3.Common;
using QLHSC3.DTO;

namespace QLHSC3.DAO
{
    class TraCuuDAO
    {
        abstract class TraCuuHocSinh
        {
            protected string sp_TraCuu;
            public abstract DataTable Search(string search);
        }
        class TraCuuHocSinh_LOP_MAHOCSINH : TraCuuHocSinh
        {
            public override DataTable Search(string search)
            {
                //search: maLop,maHocSinh
                string[] chuoi = search.Split(']');
                int maLop = Convert.ToInt32(chuoi[0]);
                int maHocSinh = Convert.ToInt32(chuoi[1]);
                sp_TraCuu = "sp_traCuu_Lop_MaHocSinh";

                SqlParameter para1 = new SqlParameter("@maLop", maLop);
                SqlParameter para2 = new SqlParameter("@maHocSinh", maHocSinh);
                DataTable bangDSHocSinh = DataProvider.executeStoreProcedureQuery(sp_TraCuu, para1, para2);
                return bangDSHocSinh;
            }
        }
        public HocSinh[] traCuuHocSinh_DAO(string search, int loaiTraCuu)
        {
            HocSinh[] dsHocSinh;
            TraCuuHocSinh tracuu = new TraCuuHocSinh_LOP_MAHOCSINH();
            DataTable bangHocSinh = tracuu.Search(search);
            dsHocSinh = layDanhSachHocSinh_Tu_Bang(bangHocSinh);
            return dsHocSinh;
        }
        public HocSinh[] layDanhSachHocSinh_Tu_Bang(DataTable bangDSHocSinh)
        {
            HocSinh[] dsHocSinh = new HocSinh[bangDSHocSinh.Rows.Count];
            for (int i = 0; i < bangDSHocSinh.Rows.Count; i++)
            {
                HocSinh hs = new HocSinh();
                hs.HoTen = bangDSHocSinh.Rows[i]["hoTen"].ToString();
                hs.NgaySinh = Convert.ToDateTime(bangDSHocSinh.Rows[i]["ngaySinh"]);
                hs.Diachi = bangDSHocSinh.Rows[i]["diaChi"].ToString();
                hs.Email = bangDSHocSinh.Rows[i]["email"].ToString();
                hs.MaTaiKhoan = Convert.ToInt32(bangDSHocSinh.Rows[i]["maTaiKhoan"]);
                if (bangDSHocSinh.Rows[i]["maLop"].ToString().CompareTo("") != 0)
                {
                    hs.MaLop = Convert.ToInt32(bangDSHocSinh.Rows[i]["maLop"]);
                }
                hs.GioiTinh = Convert.ToBoolean(bangDSHocSinh.Rows[i]["gioiTinh"]);
                hs.MaHocSinh = Convert.ToInt32(bangDSHocSinh.Rows[i]["maHocSinh"]);
                dsHocSinh[i] = hs;
            }
            return dsHocSinh;
        }
    }
}
