using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLHSC3.DTO
{
    public class GiaoVien
    {
        #region "Variable"
        int maGiaoVien;
        string hoTen;
        int maTaiKhoan;
        #endregion

        #region "Method"
        public int MaGiaoVien
        {
            get { return maGiaoVien; }
            set { maGiaoVien = value; }
        }

        public int MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        #endregion
    }
}
