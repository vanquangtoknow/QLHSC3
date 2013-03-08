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
    class DiemDAO
    {
        private Diem GetDataFromDataRow(DataTable dt, int i)
        {
            Diem diem = new Diem();
            if (dt.Rows[i]["maDiem"].ToString() == "")
            {
                diem.MaDiem = 0;
                diem.Diem15Phut = 0;
                diem.Diem1Tiet = 0;
                diem.DiemHocKi = 0;
            }
            else
            {
                diem.MaDiem = Convert.ToInt32(dt.Rows[i]["maDiem"].ToString());
                diem.Diem15Phut = Convert.ToInt32(dt.Rows[i]["diem15Phut"].ToString());
                diem.Diem1Tiet = Convert.ToInt32(dt.Rows[i]["diem1Tiet"].ToString());
                diem.DiemHocKi = Convert.ToInt32(dt.Rows[i]["diemHocKi"].ToString());
            }
            return diem;
        }

        public Diem[] getAllStudent()
        {
            string strSql = "SELECT * FROM Diem";
            DataTable dt = DataProvider.executeQuery(strSql);
            int n = dt.Rows.Count;
            Diem[] allMark = new Diem[n];
            for (int i = 0; i < n; i++)
            {
                Diem TK = GetDataFromDataRow(dt, i);
                allMark[i] = TK;
            }
            return allMark;
        }

        public Diem[] getStudentIf(int maLop, int maMonHoc, int maHocKi)
        {
            string nameProc = "sp_LayBangDiem1MonCuaLop";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@maLop",maLop);
            para[1] = new SqlParameter("@maMonHoc", maMonHoc);
            para[2] = new SqlParameter("@maHocKi", maHocKi);

            DataTable dt = DataProvider.executeStoreProcedureQuery(nameProc, para);
            int n = dt.Rows.Count;
            Diem[] allMark = new Diem[n];
            for (int i = 0; i < n; i++)
            {
                Diem TK = GetDataFromDataRow(dt, i);
                allMark[i] = TK;
            }
            return allMark;
        }

        public bool UpdateMark(Diem []diem)
        {
            string strSql = "sp_UpdateMark";
            int n;
            foreach (Diem a in diem)
            {
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@maDiem", a.MaDiem);
                para[1] = new SqlParameter("@diem15Phut", a.Diem15Phut);
                para[2] = new SqlParameter("@diem1Tiet", a.Diem1Tiet);
                para[3] = new SqlParameter("@diemHocKi", a.DiemHocKi);
                n = DataProvider.executeStoreProcedureNonQuery(strSql, para);
                if (n == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
