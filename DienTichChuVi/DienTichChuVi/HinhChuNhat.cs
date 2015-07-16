using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DienTichChuVi
{
    class HinhChuNhat
    {
        public double ChieuDai { get; set; }
        public double _ChieuRong;
        public double ChieuRong
        {
            set
            {
                if(value > 0)
                {
                    _ChieuRong = value;
                }
                else
                {
                    throw new Exception("Chieu Rong Am !");
                }
            }
            get
            {
                return _ChieuRong;
            }
        }

        public HinhChuNhat() { }
        public HinhChuNhat(double Dai, double Rong)
        {
            this.ChieuDai = Dai;
            this.ChieuRong = Rong;
        }
        public double ChuVi()
        {
            return (ChieuDai + ChieuRong) * 2;
        }
        public double DienTich()
        {
            return (ChieuDai * ChieuRong);
        }
    }
}
