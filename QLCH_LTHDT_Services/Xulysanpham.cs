using QLCH_LTHDT_Entities;
using QLCH_LTHDT_Repo;

namespace QLCH_LTHDT_Services
{
    public class Xulysanpham : ITXulysanpham
    {
        private ITLuutrusanpham _luutrusanpham = new Luutrusanpham();
        public List<Sanpham> Docdanhsachsanpham(string tukhoa ="")
        {
            List<Sanpham> kq = new List<Sanpham>();
            var dssp = _luutrusanpham.Docdanhsachsanpham();
            foreach (var sp in dssp)
            {
                if (sp.Tensanpham.Contains(tukhoa))
                {
                    kq.Add(sp);
                }
            }
            return kq;
        }
        public void Themsanpham(Sanpham sanpham)
        {
            var dssp = _luutrusanpham.Docdanhsachsanpham();
            int maxId = 0;
            foreach (var sp in dssp)
            {
                if (sp.Masanpham > maxId)
                {
                    maxId = sp.Masanpham;
                }
            }
                sanpham.Masanpham = maxId + 1;
                _luutrusanpham.Themsanpham(sanpham);
            }
                 public void Xoasanpham(Sanpham sanpham)
        {
            var dssp = _luutrusanpham.Docdanhsachsanpham();
            for (sanpham.Masanpham = 0; sanpham.Masanpham < dssp.Count - 1; sanpham.Masanpham++)
            {
                var itemToRemove = dssp.SingleOrDefault(item => item.Masanpham == sanpham.Masanpham);
                _luutrusanpham.Xoasanpham(sanpham);
            }
        }
    }
}
