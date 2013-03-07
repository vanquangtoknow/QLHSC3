using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DTO;
using System.Data;
using QLHSC3.Common;

namespace QLHSC3.DAO
{
    class MonHocDAO
    {
        private MonHoc GetDataFromDataRow(DataTable dt, int i)
        {
            MonHoc HK = new MonHoc();
            HK.MaMonHoc=Convert.ToInt32(dt.Rows[i]["maMonHoc"].ToString());
            HK.TenMonHoc = dt.Rows[i]["tenMonHoc"].ToString();
            return HK;
        }

        public MonHoc[] getAllMH()
        {
            string strSql = "SELECT * FROM MonHoc";
            DataTable dt = DataProvider.executeQuery(strSql);
            int n = dt.Rows.Count;
            MonHoc[] allClass = new MonHoc[n];
            for (int i = 0; i < n; i++)
            {
                MonHoc TK = GetDataFromDataRow(dt, i);
                allClass[i] = TK;
            }
            return allClass;
        }
    }
}
