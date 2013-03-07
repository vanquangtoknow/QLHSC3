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
    class HocSinhDAO
    {
        private LopDAO lop = new LopDAO();
        private HocSinh GetDataFromDataRow(DataTable dt, int i)
        {
            HocSinh HS = new HocSinh();
            HS.MaHocSinh = Convert.ToInt32(dt.Rows[i]["maHocSinh"].ToString());
            HS.MaLop = Convert.ToInt32(dt.Rows[i]["maLop"].ToString());
            HS.MaTaiKhoan = Convert.ToInt32(dt.Rows[i]["maTaiKhoan"].ToString());
            HS.HoTen = dt.Rows[i]["hoTen"].ToString();
            HS.GioiTinh = Convert.ToBoolean(dt.Rows[i]["gioiTinh"].ToString());
            HS.NgaySinh = Convert.ToDateTime(dt.Rows[i]["ngaySinh"].ToString());
            return HS;
        }

        public HocSinh[] getAllStudent()
        {
            string strSql = "SELECT * FROM HocSinh";
            DataTable dt = DataProvider.executeQuery(strSql);
            int n = dt.Rows.Count;
            HocSinh[] allStudent = new HocSinh[n];
            for (int i = 0; i < n; i++)
            {
                HocSinh TK = GetDataFromDataRow(dt, i);
                allStudent[i] = TK;
            }
            return allStudent;
        }

        public HocSinh[] getStudentIf(int maLop, int maMonHoc, int maHocKi)
        {
            string nameProc = "sp_LayDanhSachHocSinhCua1LopTheoMonHoc";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@maLop", maLop);
            para[1] = new SqlParameter("@maMonHoc", maMonHoc);
            para[2] = new SqlParameter("@maHocKi", maHocKi);

            DataTable dt = DataProvider.executeStoreProcedureQuery(nameProc, para);
            int n = dt.Rows.Count;
            HocSinh[] allStudent = new HocSinh[n];
            for (int i = 0; i < n; i++)
            {
                HocSinh TK = GetDataFromDataRow(dt, i);
                allStudent[i] = TK;
            }
            return allStudent;
        }

        // lay mã tài khoản từ bảng tài khoản( lấy theo tên đăng nhập)
        public int layMaTaiKhoan_TuBang_MaTaiKhoan(DataTable bangMaTaiKhoan)
        {
            return Convert.ToInt32(bangMaTaiKhoan.Rows[0]["maTaiKhoan"]);
        }
        //lay ma tài khoản của học sinh từ mã học sinh
        public int layMaTaiKhoanHS_TuBang_MaTaiKhoan(DataTable bangMaTaiKhoan)
        {
            return Convert.ToInt32(bangMaTaiKhoan.Rows[0]["maTaiKhoan"]);
        }
        public string layTenLop_TuHocSinh_DAO(HocSinh hocsinh)
        {
            string nameProc_LayDSHocSinh_DaCoLop = "sp_layTenLop_TuHocSinh";
            SqlParameter para1 = new SqlParameter("@maHocSinh", hocsinh.MaHocSinh);
            DataTable bangDSHocSinh = DataProvider.executeStoreProcedureQuery(nameProc_LayDSHocSinh_DaCoLop, para1);
            return bangDSHocSinh.Rows[0]["tenLop"].ToString();
        }
        public int layMaLop_TuHocSinh_DAO(HocSinh hocsinh)
        {
            string nameProc_LayDSHocSinh_DaCoLop = "sp_layTenLop_TuHocSinh";
            SqlParameter para1 = new SqlParameter("@maHocSinh", hocsinh.MaHocSinh);
            DataTable bangDSHocSinh = DataProvider.executeStoreProcedureQuery(nameProc_LayDSHocSinh_DaCoLop, para1);
            return Convert.ToInt32(bangDSHocSinh.Rows[0]["maLop"]);
        }
        public bool tiepNhanHocSinhDAO(HocSinh hocsinh)
        {
                string nameProc_TNHocSinh = "sp_tiepNhanHocSinh";
                string nameProc_ThemTaiKhoan = "sp_them_TaiKhoanDangNhap";
                string nameProc_LayMaTaiKhoan = "sp_layMaTaiKhoan_TheoTenTK";

                //------------------
                SqlParameter pa1 = new SqlParameter("@tenTaiKhoan", hocsinh.Email.ToLower());
                SqlParameter pa2 = new SqlParameter("@matKhau", hocsinh.Email.ToString());
                SqlParameter pa3 = new SqlParameter("@loaiTaiKhoan", 3);
                DataProvider.executeStoreProcedureNonQuery(nameProc_ThemTaiKhoan, pa1, pa2, pa3);
                SqlParameter pa = new SqlParameter("@tenTaiKhoan", hocsinh.Email.ToLower());
                DataTable bangMaTaiKhoan = DataProvider.executeStoreProcedureQuery(nameProc_LayMaTaiKhoan, pa);
                hocsinh.MaTaiKhoan = layMaTaiKhoan_TuBang_MaTaiKhoan(bangMaTaiKhoan);
                //-----------------
                SqlParameter para1 = new SqlParameter("@hoTen", hocsinh.HoTen);
                SqlParameter para2 = new SqlParameter("@ngaySinh", hocsinh.NgaySinh);
                SqlParameter para3 = new SqlParameter("@gioiTinh", hocsinh.GioiTinh);
                SqlParameter para4 = new SqlParameter("@email", hocsinh.Email);
                SqlParameter para5 = new SqlParameter("@diaChi", hocsinh.Diachi);
                SqlParameter para6 = new SqlParameter("@maTaiKhoan", hocsinh.MaTaiKhoan);

                int ketqua = DataProvider.executeStoreProcedureNonQuery(nameProc_TNHocSinh, para1, para2, para3, para4, para5, para6);
                if (ketqua != 0)
                {
                    return true;
                }
                return false;
        }
        public HocSinh[] layDanhSachHocSinh_Tu_Bang(DataTable bangDSHocSinh)
        {
            HocSinh[] dsHocSinh = new HocSinh[bangDSHocSinh.Rows.Count];
            for (int i = 0; i < bangDSHocSinh.Rows.Count; i++)
            {
                HocSinh hs = new HocSinh();
                string a = bangDSHocSinh.Rows[i]["hoTen"].ToString();
                hs.HoTen = bangDSHocSinh.Rows[i]["hoTen"].ToString();
                hs.NgaySinh = Convert.ToDateTime(bangDSHocSinh.Rows[i]["ngaySinh"]);
                hs.Diachi = bangDSHocSinh.Rows[i]["diaChi"].ToString();
                hs.Email = bangDSHocSinh.Rows[i]["email"].ToString();
                hs.MaTaiKhoan = Convert.ToInt32(bangDSHocSinh.Rows[i]["maTaiKhoan"]);
                //int l = Convert.ToInt32(bangDSHocSinh.Rows[i]["maLop"]);
                //hs.MaLop = Convert.ToInt32(bangDSHocSinh.Rows[i]["maLop"]);
                hs.GioiTinh = Convert.ToBoolean(bangDSHocSinh.Rows[i]["gioiTinh"]);
                hs.MaHocSinh = Convert.ToInt32(bangDSHocSinh.Rows[i]["maHocSinh"]);
                dsHocSinh[i] = hs;
            }
            return dsHocSinh;
        }
        public HocSinh[] layDanhSachHocSinh_DaCoLop_TuBang(DataTable bangDSHocSinh)
        {
            HocSinh[] dsHocSinh = new HocSinh[bangDSHocSinh.Rows.Count];
            for (int i = 0; i < bangDSHocSinh.Rows.Count; i++)
            {
                HocSinh hs = new HocSinh();
                string a = bangDSHocSinh.Rows[i]["hoTen"].ToString();
                hs.HoTen = bangDSHocSinh.Rows[i]["hoTen"].ToString();
                hs.NgaySinh = Convert.ToDateTime(bangDSHocSinh.Rows[i]["ngaySinh"]);
                hs.Diachi = bangDSHocSinh.Rows[i]["diaChi"].ToString();
                hs.Email = bangDSHocSinh.Rows[i]["email"].ToString();
                hs.MaTaiKhoan = Convert.ToInt32(bangDSHocSinh.Rows[i]["maTaiKhoan"]);
                hs.MaLop = Convert.ToInt32(bangDSHocSinh.Rows[i]["maLop"]);
                hs.GioiTinh = Convert.ToBoolean(bangDSHocSinh.Rows[i]["gioiTinh"]);
                hs.MaHocSinh = Convert.ToInt32(bangDSHocSinh.Rows[i]["maHocSinh"]);
                dsHocSinh[i] = hs;
            }
            return dsHocSinh;
        }
        public HocSinh[] layDanhSachHocSinh_DAO()
        {
            HocSinh[] dsHocSinh;
            string nameProc_LayDSHocSinh = "sp_layDanhSachHocSinh";
            DataTable bangDSHocSinh = DataProvider.executeStoreProcedureQuery(nameProc_LayDSHocSinh, null);
            dsHocSinh = layDanhSachHocSinh_Tu_Bang(bangDSHocSinh);
            return dsHocSinh;
        }
        // lấy danh sách học sinh trong một lớp( học sinh đã có trong lớp))
        public HocSinh[] layDanhSachHocSinh_DaCoLop_DAO(Lop lop)
        {
            HocSinh[] dsHocSinh;
            string nameProc_LayDSHocSinh_DaCoLop = "sp_layDanhSachHocSinh_DaCoLop";
            SqlParameter para1 = new SqlParameter("@maLop", lop.MaLop);
            DataTable bangDSHocSinh = DataProvider.executeStoreProcedureQuery(nameProc_LayDSHocSinh_DaCoLop, para1);
            dsHocSinh = layDanhSachHocSinh_DaCoLop_TuBang(bangDSHocSinh);
            return dsHocSinh;
        }
        public HocSinh[] layDanhSachHocSinh_ChuaCoLop_DAO()
        {
            HocSinh[] dsHocSinh;
            string nameProc_LayDSHocSinh_ChuaCoLop = "sp_layDanhSachHocSinh_ChuaCoLop";
            DataTable bangDSHocSinh_ChuaCoLop = DataProvider.executeStoreProcedureQuery(nameProc_LayDSHocSinh_ChuaCoLop, null);
            dsHocSinh = layDanhSachHocSinh_Tu_Bang(bangDSHocSinh_ChuaCoLop);
            return dsHocSinh;
        }
        public bool xoaHocSinh_DAO(HocSinh hocsinh)
        {
            string nameProc_XoaHocSinh = "sp_xoaHocSinh";
            string nameProc_XoaTaiKhoan = "sp_xoa_TaiKhoanDangNhap";
            string nameProc_LayMaTaiKhoanHS = "sp_layHocSinh";
            //---------
            SqlParameter para1 = new SqlParameter("@maHocSinh", hocsinh.MaHocSinh);


            //------------------
            DataTable bangMaTaiKhoan = DataProvider.executeStoreProcedureQuery(nameProc_LayMaTaiKhoanHS, para1);
            hocsinh.MaTaiKhoan = layMaTaiKhoanHS_TuBang_MaTaiKhoan(bangMaTaiKhoan);
            SqlParameter para2 = new SqlParameter("@maTaiKhoan", hocsinh.MaTaiKhoan);
            SqlParameter para3 = new SqlParameter("@maHocSinh", hocsinh.MaHocSinh);
            int ketqua = DataProvider.executeStoreProcedureNonQuery(nameProc_XoaHocSinh, para3);
            DataProvider.executeStoreProcedureNonQuery(nameProc_XoaTaiKhoan, para2);
            if (ketqua != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool suaHocSinh_DAO(HocSinh hocsinh)
        {
            string nameProc_TNHocSinh = "sp_suaHocSinh";
            SqlParameter para = new SqlParameter("@maHocSinh", hocsinh.MaHocSinh);
            SqlParameter para1 = new SqlParameter("@hoTen", hocsinh.HoTen);
            SqlParameter para2 = new SqlParameter("@ngaySinh", hocsinh.NgaySinh);
            SqlParameter para3 = new SqlParameter("@gioiTinh", hocsinh.GioiTinh);
            SqlParameter para4 = new SqlParameter("@email", hocsinh.Email);
            SqlParameter para5 = new SqlParameter("@diaChi", hocsinh.Diachi);
            int ketqua = DataProvider.executeStoreProcedureNonQuery(nameProc_TNHocSinh, para, para1, para2, para3, para4, para5);
            if (ketqua != 0)
            {
                return true;
            }
            return false;
        }
        public bool kiemTraSoLuongHocSinh_TrongMotLop(int maLop)
        {
            string name_Proc_KiemTraSoLuongHocSinh = "sp_laySoLuongHocSinhToiDa_TrongMotLop";
            SqlParameter para1 = new SqlParameter("@tenQuyDinh", "Số lượng tối đa trong một lớp");
            DataTable bangQuyDinh = DataProvider.executeStoreProcedureQuery(name_Proc_KiemTraSoLuongHocSinh, para1);
            int soluonghs_max = Int32.Parse(bangQuyDinh.Rows[0]["noiDungQuyDinh"].ToString());

            //-------
            string name_Proc_LaySoLuongHocSinhHienTai = "sp_demSoLuongHocSinh_DaCoLop";
            SqlParameter para2 = new SqlParameter("@maLop", maLop);
            DataTable bangSoLuongHS = DataProvider.executeStoreProcedureQuery(name_Proc_LaySoLuongHocSinhHienTai, para2);
            int soluonghs_Current = Convert.ToInt32(bangSoLuongHS.Rows[0]["soLuongHocSinh"]);
            if (soluonghs_Current < soluonghs_max)
            {
                return true;
            }
            return false;
        }
        public bool themHocSinh_VaoLop_DAO(HocSinh hocsinh, Lop lop)
        {
            bool kiemtra_soluonghs = kiemTraSoLuongHocSinh_TrongMotLop(lop.MaLop);
            if (kiemtra_soluonghs == true)
            {
                string nameProc_ThemHocSinh_VaoLop = "sp_themHocSinh_VaoLop";
                SqlParameter para1 = new SqlParameter("@maHocSinh", hocsinh.MaHocSinh);
                SqlParameter para2 = new SqlParameter("@maLop", lop.MaLop);
                int ketqua = DataProvider.executeStoreProcedureNonQuery(nameProc_ThemHocSinh_VaoLop, para1, para2);
                if (ketqua != 0)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        public bool xoaHocSinh_RaKhoiLop_DAO(HocSinh hocsinh)
        {
            string nameProc_ThemHocSinh_VaoLop = "sp_xoaHocSinh_RaKhoiLop";
            SqlParameter para1 = new SqlParameter("@maHocSinh", hocsinh.MaHocSinh);
            int ketqua = DataProvider.executeStoreProcedureNonQuery(nameProc_ThemHocSinh_VaoLop, para1);
            if (ketqua != 0)
            {
                return true;
            }
            return false;
        }
        public bool suaHocSinh_SuaLop_DAO(HocSinh hocsinh, Lop lop)
        {
            string nameProc_SuaHocSinh_SuaLop = "sp_suaHocSinh_SuaLop";
            SqlParameter para1 = new SqlParameter("@maHocSinh", hocsinh.MaHocSinh);
            SqlParameter para2 = new SqlParameter("@maLop", lop.MaLop);
            int ketqua = DataProvider.executeStoreProcedureNonQuery(nameProc_SuaHocSinh_SuaLop, para1, para2);
            if (ketqua != 0)
            {
                return true;
            }
            return false;
        }
    }
}
