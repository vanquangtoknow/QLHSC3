using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLHSC3.Common;
using QLHSC3.DTO;
using QLHSC3.DAO;

namespace QLHSC3.BUS
{
    public class TraCuuBUS
    {
        private TraCuuDAO tracuu = new TraCuuDAO();
        public HocSinh[] traCuuHocSinh_BUS(string search,int loaiTraCuu)
        {
            return tracuu.traCuuHocSinh_DAO(search, 1);
        }

    }
}
