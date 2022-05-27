using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QL_bar.Model
{
    class quenmk
    {
        private string _TenNV;
        private string _SoDT;

        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public string SoDT { get => _SoDT; set => _SoDT = value; }
        public quenmk() { }

        public quenmk(string tenNV, string soDT)
        {
            _TenNV = tenNV;
            _SoDT = soDT;
        }
        public quenmk(SqlDataReader rd)
        {
            
            _TenNV = rd["TenNV"].ToString();
            _SoDT = rd["SoDT"].ToString();

        }
    }
}
