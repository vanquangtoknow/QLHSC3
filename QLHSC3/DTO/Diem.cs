using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLHSC3.DTO
{
    public class Diem
    {
        int maDiem;

        public int MaDiem
        {
            get { return maDiem; }
            set { maDiem = value; }
        }
        float diem15Phut;

        public float Diem15Phut
        {
            get { return diem15Phut; }
            set { diem15Phut = value; }
        }
        float diem1Tiet;

        public float Diem1Tiet
        {
            get { return diem1Tiet; }
            set { diem1Tiet = value; }
        }
        float diemHocKi;

        public float DiemHocKi
        {
            get { return diemHocKi; }
            set { diemHocKi = value; }
        }
    }
}
