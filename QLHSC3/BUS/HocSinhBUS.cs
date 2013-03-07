using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DAO;
using QLHSC3.DTO;

namespace QLHSC3.BUS
{
    public class HocSinhBUS
    {
        private HocSinhDAO hocsinhDAO= new HocSinhDAO();
        public HocSinhBUS()
        {
        }
        public bool themHocSinh_BUS(HocSinh hocsinh)
        {

            //neu them thi có trả về là thêm đx hay không
            
            return hocsinhDAO.tiepNhanHocSinhDAO(hocsinh);
        }
        public HocSinh[] layDanhSachHocSinh_BUS()
        {
            return hocsinhDAO.layDanhSachHocSinh_DAO();
        }
        public HocSinh[] layDanhSachHocSinh_ChuaCoLop_BUS()
        {
            return hocsinhDAO.layDanhSachHocSinh_ChuaCoLop_DAO();
        }
        public HocSinh[] layDanhSachHocSinh_DaCoLop_BUS(Lop lop)
        {
            return hocsinhDAO.layDanhSachHocSinh_DaCoLop_DAO(lop);
        }
        public bool xoaHocSinh_BUS(HocSinh hocsinh)
        {
            return hocsinhDAO.xoaHocSinh_DAO(hocsinh);
        }
        public bool suaHocSinh_BUS(HocSinh hocsinh)
        {
            return hocsinhDAO.suaHocSinh_DAO(hocsinh);
        }
        public string layTenLop_TuHocSinh_BUS(HocSinh hocsinh)
        {
            return hocsinhDAO.layTenLop_TuHocSinh_DAO(hocsinh);
        }
        public int layMaLop_TuHocSinh_BUS(HocSinh hocsinh)
        {
            return hocsinhDAO.layMaLop_TuHocSinh_DAO(hocsinh);
        }
        public bool xoaHocSinh_RaKhoiLop_BUS(HocSinh hocsinh)
        {
            return hocsinhDAO.xoaHocSinh_RaKhoiLop_DAO(hocsinh);
        }
        public bool themHocSinh_VaoLop_BUS(HocSinh hocsinh, Lop lop)
        {
            return hocsinhDAO.themHocSinh_VaoLop_DAO(hocsinh, lop);
        }
        public bool suaHocSinh_SuaLop_DAO(HocSinh hocsinh, Lop lop)
        {
            return hocsinhDAO.suaHocSinh_SuaLop_DAO(hocsinh, lop);
        }


    }
}
