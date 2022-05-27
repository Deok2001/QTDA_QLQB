using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QL_bar.Model
{
    class Baocao
    {
        private string _MaBC;
        private string _LoaiBC;
        private string _NgayBC;
        private int _SoLuongDV;
        private int _DoanhThu;
        private string _MaNV;


        public string MaBC { get => _MaBC; set => _MaBC = value; }
        public string LoaiBC { get => _LoaiBC; set => _LoaiBC = value; }
        public string NgayBC { get => _NgayBC; set => _NgayBC = value; }
        public int SoLuongDV { get => _SoLuongDV; set => _SoLuongDV = value; }
        public int DoanhThu { get => _DoanhThu; set => _DoanhThu = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public Baocao(SqlDataReader rd)
        {
            _MaBC = rd["MaBC"].ToString();
            _LoaiBC = rd["LoaiBC"].ToString();
            _NgayBC = rd["NgayBC"].ToString();
            _SoLuongDV = (int)rd["SoLuongDV"];
            _DoanhThu = (int)rd["DoanhThu"];
            _MaNV = rd["MaNV"].ToString();

        }

        public Baocao(string maBC, string loaiBC, string ngayBC, int soLuongDV, int doanhThu, string maNV)
        {
            _MaBC = maBC;
            _LoaiBC = loaiBC;
            _NgayBC = ngayBC;
            _SoLuongDV = soLuongDV;
            _DoanhThu = doanhThu;
            _MaNV = maNV;
        }

        
    }
    
}
