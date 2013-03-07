using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using QLHSC3.Common;
using QLHSC3.DTO;
using System.Data;

namespace QLHSC3.DAO
{
    class QuyDinhDAO
    {
        public bool ThemQuyDinh(string tenQD, string noiDungQD)
        {
            string nameProc = "sp_ThemQuyDinhMoi";
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@tenQuyDinh", tenQD);
            para[1] = new SqlParameter("@noiDungQuyDinh", noiDungQD);

            if (DataProvider.executeStoreProcedureNonQuery(nameProc, para) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool ThayDoiQuyDinh(QuyDinh quyDinh)
        {
            string strSql = "sp_ThayDoiQuyDinh";
            int n;
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@maQuyDinh", quyDinh.MaQuyDinh);
            para[1] = new SqlParameter("@noiDungQuyDinh", quyDinh.NoiDungQuyDinh);
            n = DataProvider.executeStoreProcedureNonQuery(strSql, para);
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        private QuyDinh GetDataFromDataRow(DataTable dt, int i)
        {
            QuyDinh quyDinh = new QuyDinh();
            quyDinh.MaQuyDinh = Convert.ToInt32(dt.Rows[i]["maQuyDinh"].ToString());
            quyDinh.TenQuyDinh = dt.Rows[i]["tenQuyDinh"].ToString();
            quyDinh.NoiDungQuyDinh = dt.Rows[i]["noiDungQuyDinh"].ToString();
            return quyDinh;
        }

        public QuyDinh[] getAllQuyDinh()
        {
            string strSql = "SELECT * FROM QuyDinh";
            DataTable dt = DataProvider.executeQuery(strSql);
            int n = dt.Rows.Count;
            QuyDinh[] allMark = new QuyDinh[n];
            for (int i = 0; i < n; i++)
            {
                QuyDinh TK = GetDataFromDataRow(dt, i);
                allMark[i] = TK;
            }
            return allMark;
        }

        public bool XoaQuyDinh(QuyDinh quyDinh)
        {
            string strSql = "DELETE FROM QuyDinh WHERE maQuyDinh='" + quyDinh.MaQuyDinh + "'";
            int n = DataProvider.executeNonQuery(strSql);
            if (n == 0)
            {
                return false;
            }
            
            return true;
        }
    }
}
