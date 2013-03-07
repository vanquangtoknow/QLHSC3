using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLHSC3.DTO
{
    public class ThongBao
    {
        int maThongBao;
        DateTime ngayThongBao;

        public DateTime NgayThongBao
        {
            get { return ngayThongBao; }
            set { ngayThongBao = value; }
        }
        public int MaThongBao
        {
            get { return maThongBao; }
            set { maThongBao = value; }
        }
        string tenThongBao;

        public string TenThongBao
        {
            get { return tenThongBao; }
            set { tenThongBao = value; }
        }
        string noiDungThongBao;

        public string NoiDungThongBao
        {
            get { return noiDungThongBao; }
            set { noiDungThongBao = value; }
        }
    }
}
