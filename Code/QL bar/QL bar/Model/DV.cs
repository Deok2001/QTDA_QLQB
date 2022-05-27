using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QL_bar.Model
{
    class DV
    {
        private string _TenDV;
        private int _SoLuong;
        private int _DonGia;
        private string _MaKH;
        private int _ThanhTien;
        
        public DV() { }
        public DV(SqlDataReader rd)
        {
            _TenDV = rd["TenDV"].ToString();
            _SoLuong = (int)rd["SoLuong"];
            _DonGia = (int)rd["DonGia"];
            _MaKH = rd["MaKH"].ToString();
            _ThanhTien = (int)rd["ThanhTien"];
        }

        public DV(string tenDV, int soLuong, int donGia, string maKH, int thanhTien)
        {
            _TenDV = tenDV;
            _SoLuong = soLuong;
            _DonGia = donGia;
            _MaKH = maKH;
            _ThanhTien = thanhTien;
        }

        public string TenDV { get => _TenDV; set => _TenDV = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public int DonGia { get => _DonGia; set => _DonGia = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public int ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
    }
}
