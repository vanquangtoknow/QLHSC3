using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DAO;
using QLHSC3.DTO;

namespace QLHSC3.BUS
{
    public class LopBUS
    {
        private LopDAO lopDAO = new LopDAO();
        public Lop[] layDanhSachLop_BUS()
        {
            return lopDAO.layDanhSachLop_DAO();
        }
        public string layTenGiaoVien_Tu_MaLop_BUS(int maLop)
        {
            return lopDAO.layTenGiaoVien_Tu_MaLop_DAO(maLop);
        }
        public string layTenLop_Tu_MaLop_BUS(int maLop)
        {
            return lopDAO.layTenLop_Tu_MaLop_DAO(maLop);
        }
        public int laySoLuongHocSinhToiDa_TrongMotLop_BUS(int maLop)
        {
            return lopDAO.laySoLuongHocSinhToiDa_TrongMotLop_DAO(maLop);
        }
    }
}
