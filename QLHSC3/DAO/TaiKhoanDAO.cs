using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DTO;
using System.Data;
using QLHSC3.Common;

namespace QLHSC3.DAO
{
    class TaiKhoanDAO
    {
        private TaiKhoanDangNhap GetDataFromDataRow(DataTable dt, int i)
        {
            TaiKhoanDangNhap TK = new TaiKhoanDangNhap();
            TK.MaTaiKhoan =Convert.ToInt32(dt.Rows[i]["maTaiKhoan"].ToString());
            TK.LoaiTaiKhoan = Convert.ToInt32(dt.Rows[i]["loaiTaiKhoan"].ToString());
            TK.TenTaiKhoan = dt.Rows[i]["tenTaiKhoan"].ToString();
            TK.MatKhau = dt.Rows[i]["matKhau"].ToString();
            return TK;
        }

        public TaiKhoanDangNhap[] getAllUser()
        {
            string strSql = "SELECT * FROM TaiKhoanDangNhap";
            DataTable dt = DataProvider.executeQuery(strSql) ;
            int n = dt.Rows.Count;
            TaiKhoanDangNhap[] allUser = new TaiKhoanDangNhap[n];
            for (int i = 0; i < n; i++)
            {
                TaiKhoanDangNhap TK = GetDataFromDataRow(dt, i);
                allUser[i] = TK;
            }
            return allUser;
        }
    }
}
