using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QL_bar.Model
{
    class Kho
    {
        private string _MaNL;
        private string _TenNL;
        private string _NgaySuDung;
        private string _DonGia;
        private string _MaNV;

        public string MaNL { get => _MaNL; set => _MaNL = value; }
        public string TenNL { get => _TenNL; set => _TenNL = value; }
        public string NgaySuDung { get => _NgaySuDung; set => _NgaySuDung = value; }
        public string DonGia { get => _DonGia; set => _DonGia = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }

        public Kho() { }

        public Kho(SqlDataReader rd)
        {
            _MaNL = rd["MaNL"].ToString();
            _TenNL = rd["TenNL"].ToString();
            _NgaySuDung = rd["NgaySuDung"].ToString();
            _DonGia = rd["DonGia"].ToString();
            _MaNV = rd["MaNV"].ToString();
        }
        public Kho(string maNL, string tenNL, string ngaySuDung, string donGia, string maNV)
        {
            _MaNL = maNL;
            _TenNL = tenNL;
            _NgaySuDung = ngaySuDung;
            _DonGia = donGia;
            _MaNV = maNV;
        }

        


    }
}
