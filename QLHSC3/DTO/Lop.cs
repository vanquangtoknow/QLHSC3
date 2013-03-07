using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLHSC3.DTO
{
    public class Lop
    {

        #region "Variable"
        int maLop;
        string tenLop;
        int siSo;
        int maKHoi;
        int maGV_ChuNhiem;
        #endregion

        #region "Method"
        public int MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }
        public int SiSo
        {
            get { return siSo; }
            set { siSo = value; }
        }
        public int MaKHoi
        {
            get { return maKHoi; }
            set { maKHoi = value; }
        }
        public int MaGV_ChuNhiem
        {
            get { return maGV_ChuNhiem; }
            set { maGV_ChuNhiem = value; }
        }
        #endregion

        

        
    }
}
