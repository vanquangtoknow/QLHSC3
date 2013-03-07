using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLHSC3.DTO
{
    public class GiaoVu
    {
        #region "Variable"
        int maGiaoVu;
        string hoTen;
        int maTaiKhoan;
        int maKhoi;
        #endregion
       
        #region "Method"

        public int MaKhoi
        {
            get { return maKhoi; }
            set { maKhoi = value; }
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

        public int MaGiaoVu
        {
            get { return maGiaoVu; }
            set { maGiaoVu = value; }
        }

        #endregion
    }
}
