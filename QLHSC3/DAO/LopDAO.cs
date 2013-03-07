using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DTO;
using System.Data;
using QLHSC3.Common;
using System.Data.SqlClient;

namespace QLHSC3.DAO
{
    class LopDAO
    {
        private Lop GetDataFromDataRow(DataTable dt, int i)
        {
            Lop lop = new Lop();
            lop.MaGV_ChuNhiem = Convert.ToInt32(dt.Rows[i]["maGV_ChuNhiem"].ToString());
            lop.MaLop = Convert.ToInt32(dt.Rows[i]["maLop"].ToString());
            lop.MaKHoi = Convert.ToInt32(dt.Rows[i]["maKhoi"].ToString());
            lop.TenLop = dt.Rows[i]["tenLop"].ToString();
            lop.SiSo =Convert.ToInt32(dt.Rows[i]["siSo"].ToString());
            return lop;
        }

        public Lop[] getAllClass()
        {
            string strSql = "SELECT * FROM Lop";
            DataTable dt = DataProvider.executeQuery(strSql);
            int n = dt.Rows.Count;
            Lop[] allClass = new Lop[n];
            for (int i = 0; i < n; i++)
            {
                Lop TK = GetDataFromDataRow(dt, i);
                allClass[i] = TK;
            }
            return allClass;
        }

        public int soLuongDat(int maMonHoc, int maHocKi, int maLop)
        {
            string nameProc = "sp_SoLuongHocSinhDat";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@maLop", maLop);
            para[1] = new SqlParameter("@maMonHoc", maMonHoc);
            para[2] = new SqlParameter("@maHocKi", maHocKi);
            int n = DataProvider.ExecuteScalarProcedureNonQuery(nameProc, para);
            return n;
        }
        public int soLuongDatHocKi(int maHocKi, int maLop)
        {
            string nameProc = "sp_SoLuongHocSinhDatHocKi";
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@maLop", maLop);
            para[1] = new SqlParameter("@maHocKi", maHocKi);
            int n = DataProvider.ExecuteScalarProcedureNonQuery(nameProc, para);
            return n;
        }
        public int laySoLuongHocSinhToiDa_TrongMotLop_DAO(int maLop)
        {
            string name_Proc_KiemTraSoLuongHocSinh = "sp_laySoLuongHocSinhToiDa_TrongMotLop";
            SqlParameter para1 = new SqlParameter("@tenQuyDinh", "Số lượng tối đa trong một lớp");
            DataTable bangQuyDinh = DataProvider.executeStoreProcedureQuery(name_Proc_KiemTraSoLuongHocSinh, para1);
            int soluonghs_max = Int32.Parse(bangQuyDinh.Rows[0]["noiDungQuyDinh"].ToString());
            return soluonghs_max;
        }


        public Lop[] layDanhSachLop_DAO()
        {
            Lop[] dsLop;
            string name_Proc_LayDSLop = "sp_layDanhSachLop";
            DataTable bangDSLop = DataProvider.executeStoreProcedureQuery(name_Proc_LayDSLop, null);
            dsLop = layDanhSachLop_Tu_Bang(bangDSLop);
            return dsLop;
        }
        public Lop[] layDanhSachLop_Tu_Bang(DataTable bangDSLop)
        {
            Lop[] dsLop = new Lop[bangDSLop.Rows.Count];
            for (int i = 0; i < bangDSLop.Rows.Count; i++)
            {
                Lop lop = new Lop();
                lop.MaLop = Convert.ToInt32(bangDSLop.Rows[i]["maLop"]);
                lop.TenLop = bangDSLop.Rows[i]["tenLop"].ToString();
                lop.SiSo = Convert.ToInt32(bangDSLop.Rows[i]["siSo"]);
                lop.MaKHoi = Convert.ToInt32(bangDSLop.Rows[i]["maKhoi"]);
                lop.MaGV_ChuNhiem = Convert.ToInt32(bangDSLop.Rows[i]["maGV_ChuNhiem"]);
                dsLop[i] = lop;
            }
            return dsLop;
        }
        public string layTenGiaoVien_Tu_MaLop_DAO(int maLop)
        {
            string name_Proc_LayTenGiaoVien_MaLop = "sp_layTenGiaoVien_Tu_MaLop";
            SqlParameter para1 = new SqlParameter("@maLop", maLop);
            DataTable bangDSLop = DataProvider.executeStoreProcedureQuery(name_Proc_LayTenGiaoVien_MaLop, para1);
            if (bangDSLop.Rows.Count != 0)
            {
                return bangDSLop.Rows[0]["hoTen"].ToString();
            }
            return null;
        }
        public string layTenLop_Tu_MaLop_DAO(int maLop)
        {
            string name_Proc_LayTenGiaoVien_MaLop = "sp_layTenLop_Tu_MaLop";
            SqlParameter para1 = new SqlParameter("@maLop", maLop);
            DataTable bangDSLop = DataProvider.executeStoreProcedureQuery(name_Proc_LayTenGiaoVien_MaLop, para1);
            if (bangDSLop.Rows.Count != 0)
            {
                return bangDSLop.Rows[0]["tenLop"].ToString();
            }
            return null;
        }
        public string layThoiKhoaBieu_Tu_MaLop(int maLop)
        {
            string name_Proc_LayTenGiaoVien_MaLop = "sp_layTenLop_Tu_MaLop";
            SqlParameter para1 = new SqlParameter("@maLop", maLop);
            DataTable bangDSLop = DataProvider.executeStoreProcedureQuery(name_Proc_LayTenGiaoVien_MaLop, para1);
            if (bangDSLop.Rows.Count != 0)
            {
                return bangDSLop.Rows[0]["thoiKhoaBieu"].ToString();
            }
            return null;
        }

    }
}
