using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLHSC3.DTO
{
    public class TaiKhoanDangNhap
    {
        int loaiTaiKhoan;

        public int LoaiTaiKhoan
        {
            get { return loaiTaiKhoan; }
            set { loaiTaiKhoan = value; }
        }

        int maTaiKhoan;

        public int MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
        }
        string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }
        string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public TaiKhoanDangNhap()
        {
        }

        public TaiKhoanDangNhap(string _tenTK,string _matKhau)
        {
            tenTaiKhoan = _tenTK;
            matKhau= _matKhau;
        }

        public int kiemTraTaiKhoanDangNhap(TaiKhoanDangNhap taiKhoanCanKiemTra)
        {
            if(tenTaiKhoan.CompareTo(taiKhoanCanKiemTra.tenTaiKhoan)==0 
               && matKhau.CompareTo(taiKhoanCanKiemTra.matKhau)==0)
            {
                if (loaiTaiKhoan == 4)  // ban giam hieu
                {
                    return 4;
                }
                else if (loaiTaiKhoan == 1)// giao vu
                {
                    return 1;
                }
                else if (loaiTaiKhoan == 2)// giao vien
                {
                    return 2;
                }
                else
                {
                    return 3;   // hoc sinh
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
