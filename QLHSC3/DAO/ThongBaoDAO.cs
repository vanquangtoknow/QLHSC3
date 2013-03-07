using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DTO;
using System.Data.SqlClient;
using QLHSC3.Common;
using System.Data;

namespace QLHSC3.DAO
{
    public class ThongBaoDAO
    {
        public void taoThongBao_DAO(ThongBao thongbao)
        {
            string name_Proc_TaoThongBao = "sp_taoThongBao";
            SqlParameter para1 = new SqlParameter("@tenThongBao", thongbao.TenThongBao);
            SqlParameter para2 = new SqlParameter("@noiDungThongBao", thongbao.NoiDungThongBao);
            SqlParameter para3 = new SqlParameter("@ngayThongBao", thongbao.NgayThongBao);
            DataProvider.executeStoreProcedureQuery(name_Proc_TaoThongBao, para1,para2,para3);
        }
        public ThongBao[] layDanhSachThongBao_Tu_bang(DataTable bangThongBao)
        {
            ThongBao[] dsThongBao = new ThongBao[bangThongBao.Rows.Count];
            for (int i = 0; i < bangThongBao.Rows.Count; i++)
            {
                ThongBao tb = new ThongBao();
                tb.MaThongBao = Convert.ToInt32(bangThongBao.Rows[i]["maThongBao"]);
                tb.TenThongBao = bangThongBao.Rows[i]["tenThongBao"].ToString();
                tb.NgayThongBao = Convert.ToDateTime(bangThongBao.Rows[i]["ngayThongBao"]);
                tb.NoiDungThongBao = bangThongBao.Rows[i]["noiDungThongBao"].ToString();
                dsThongBao[i] = tb;
            }
            return dsThongBao;
        }
        public ThongBao[] layTatCaThongBao_DAO()
        {
            ThongBao[] dsThongBao;
            string name_Proc_LayTatCaThongBao = "sp_layTatCaThongBao";
            DataTable table = DataProvider.executeStoreProcedureQuery(name_Proc_LayTatCaThongBao);
            dsThongBao = layDanhSachThongBao_Tu_bang(table);
            return dsThongBao;
        }
        public void xoaThongBao_MaThongBao_DAO(int maThongBao)
        {
            string name_Proc_XoaThongBao_MaThongBao = "sp_xoaThongBao_MaThongBao";
            SqlParameter para1 = new SqlParameter("@maThongBao", maThongBao);
            DataProvider.executeStoreProcedureNonQuery(name_Proc_XoaThongBao_MaThongBao, para1);
        }
    }
}
