using QLCH_LTHDT_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_LTHDT_Services
{
    public interface ITXulysanpham
    {
        List<Sanpham> Docdanhsachsanpham(string tukhoa ="");
        void Themsanpham(Sanpham sanpham);
    }
}
