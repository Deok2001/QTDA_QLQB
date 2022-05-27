using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QL_bar.Model
{
    class KhachHang
    {
        private string _MaKH;
        private string _TenKH;
        private string _SoDT;
        private string _DiaChi;
        private string _MaNV;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string SoDT { get => _SoDT; set => _SoDT = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }



        public KhachHang() { }
        public KhachHang(SqlDataReader rd)
        {
            _MaKH = rd["MaKH"].ToString();
            _TenKH = rd["TenKH"].ToString();
            _SoDT = rd["SoDT"].ToString();
            _DiaChi = rd["DiaChi"].ToString();
            _MaNV = rd["MaNV"].ToString();
        }

        public KhachHang(string maKH, string tenKH, string soDT, string diaChi, string maNV)
        {
            _MaKH = maKH;
            _TenKH = tenKH;
            _SoDT = soDT;
            _DiaChi = diaChi;
            _MaNV = maNV;
        }

        
    }
}
