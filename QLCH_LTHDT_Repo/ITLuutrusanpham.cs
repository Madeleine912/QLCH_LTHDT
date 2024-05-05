using QLCH_LTHDT_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_LTHDT_Repo
{
    public interface ITLuutrusanpham
    {
        List<Sanpham> Docdanhsachsanpham();
        void Themsanpham(Sanpham sanpham);

    }
}
