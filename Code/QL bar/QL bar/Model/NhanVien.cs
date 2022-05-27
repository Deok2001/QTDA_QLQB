using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QL_bar.Model
{
    class NhanVien
    {
        private string _MaNV;
        private string _TenNV;
        private string _NgaySinh;
        private string _SoDT;
        private string _DiaChi;
        private string _ChucVu;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string SoDT { get => _SoDT; set => _SoDT = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string ChucVu { get => _ChucVu; set => _ChucVu = value; }

        public NhanVien() { }
        public NhanVien(SqlDataReader rd)
        {
            _MaNV = rd["MaNV"].ToString();
            _TenNV = rd["TenNV"].ToString();
            _NgaySinh = rd["NgaySinh"].ToString();
            _SoDT = rd["SoDT"].ToString();
            _DiaChi = rd["DiaChi"].ToString();
            _ChucVu = rd["ChucVu"].ToString();
           
        }

        public NhanVien(string maNV, string tenNV, string ngaySinh, string soDT, string diaChi, string chucVu)
        {
            _MaNV = maNV;
            _TenNV = tenNV;
            _NgaySinh = ngaySinh;
            _SoDT = soDT;
            _DiaChi = diaChi;
            _ChucVu = chucVu;
        }
    }
}
