using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLHSC3.DTO
{
    public class Khoi
    {

        #region "Variable"
        int maKhoi;
        string tenKhoi;
        #endregion

        #region "Method"

        public int MaKhoi
        {
            get { return maKhoi; }
            set { maKhoi = value; }
        }


        public string TenKhoi
        {
            get { return tenKhoi; }
            set { tenKhoi = value; }
        }
        #endregion

      

    }
}
