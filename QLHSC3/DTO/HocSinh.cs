using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace QLHSC3.DTO
{
    public class HocSinh
    {
        #region "Variable"
        int maLop;
        int maHocSinh;
        int maTaiKhoan;
        string hoTen;
        DateTime ngaySinh;
        bool gioiTinh;
        string email;
        string diaChi;

        public string Diachi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        #endregion

        #region "Method"
        public int MaHocSinh
        {
            get { return maHocSinh; }
            set { maHocSinh = value; }
        }


        public int MaLop
        {
            get { return maLop; }
            set { maLop = value; }
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


        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }


        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion
       
    }
}
